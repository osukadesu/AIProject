using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estado : MonoBehaviour
{
    public Transform userCon;
    public float posX = 261.6f, posY = 1.64f, posZ = 88.32579f, roX = 0, roY = 0, roZ = 0;
    private void Start()
    {
        userCon.transform.position = new Vector3(posX, posY, posZ);
        userCon.transform.Rotate(roX,roY,roZ);
    }
}