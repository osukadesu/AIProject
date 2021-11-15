using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoE : MonoBehaviour
{
    public int daño = 100;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<LogicaVida>().RestarVida(daño);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<LogicaVida>().RestarVida(daño);
        }
    }
}
