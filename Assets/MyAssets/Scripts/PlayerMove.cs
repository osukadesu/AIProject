using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    float posX = 0, posY =0, posZ = 0, roX = 0, roY = 0, roZ = 0;
    public Transform playerT;
    public CharacterController controller;
    public float speed = 10f;
    public float speedrun = 20f;
    public float gravity = -9.8f;
    Vector3 velocity;
    public Transform gruoundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;

    public float jumpheight = 3f;

    void Start() 
    {
        posX = PlayerPrefs.GetFloat("px");
        posY = PlayerPrefs.GetFloat("py");
        posZ = PlayerPrefs.GetFloat("pz");
        roX = PlayerPrefs.GetFloat("rx");
        roY = PlayerPrefs.GetFloat("ry");
        roZ = PlayerPrefs.GetFloat("rz");

        playerT.transform.position = new Vector3(posX, posY, posZ);
        playerT.transform.Rotate(roX,roY,roZ);
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(gruoundCheck.position, groundDistance, groundMask);
        if (isGrounded && velocity.y <= 0)
        {
            velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpheight * -2 * gravity);
        }
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.G))
        {
            Guardar();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            Cargar();
        }
    }

     public void Guardar()
   {
       PlayerPrefs.SetFloat("px", playerT.transform.position.x);
       PlayerPrefs.SetFloat("py", playerT.transform.position.y);
       PlayerPrefs.SetFloat("pz", playerT.transform.position.z);
       
       PlayerPrefs.SetFloat("rx", playerT.transform.rotation.x);
       PlayerPrefs.SetFloat("ry", playerT.transform.rotation.y);
       PlayerPrefs.SetFloat("rz", playerT.transform.rotation.z);
   }
     public void Cargar()
    {
        SceneManager.LoadScene(1); 
   }
}