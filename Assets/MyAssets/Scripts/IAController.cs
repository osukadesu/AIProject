using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAController : MonoBehaviour
{
    public int time;
    public float speed = 5f;
    float y;
    public bool rotime;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time += 1;
        transform.Translate(transform.forward * speed * Time.fixedDeltaTime);
        transform.Rotate(new Vector3(0, y, 0));
        if (time >= Random.Range(100, 2500))
        {
            Rotatar();
            rotime = true;
            time = 0;
        }
        if (rotime == true)
        {
            if (time >= Random.Range(50, 100))
            {
                y = 0;
                rotime = false;
            }
        }
    }
    public void Rotatar()
    {
        y = Random.Range(-3, 3);
    }
}
