using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoP : MonoBehaviour
{
    public int daño = 100;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Virus")
        {
            other.GetComponent<LogicaVidaViruz>().RestarVida(daño);
        }
    }
}
