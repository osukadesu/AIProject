using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diaynoche : MonoBehaviour
{
    public float min, grado;
    public float timespeed = 1;
    public Light luna;

    void Update()
    {
        //1 dia 24 min
        min += timespeed * Time.deltaTime;

        if (min >= 1440) //1440 24/h
        {
            min = 0;
        }
        grado = min / 4;
        this.transform.localEulerAngles = new Vector3(grado, 0f, 0f);
        if (grado >= 180)
        {
            this.GetComponent<Light>().enabled = false;
            luna.enabled = true;
        }
        else
        {
            this.GetComponent<Light>().enabled = true;
            luna.enabled = false;
        }
    }
}
