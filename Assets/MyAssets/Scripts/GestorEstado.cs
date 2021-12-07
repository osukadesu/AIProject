using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestorEstado : MonoBehaviour
{
    public static void Guardar(MonoBehaviour componente)
    {
        Estado estado = (Estado) componente;
        PlayerPrefs.SetFloat("px", estado.transform.position.x);
        PlayerPrefs.SetFloat("py", estado.transform.position.y);
        PlayerPrefs.SetFloat("pz", estado.transform.position.z);

        PlayerPrefs.SetFloat("rx", estado.transform.rotation.x);
        PlayerPrefs.SetFloat("ry", estado.transform.rotation.y);
        PlayerPrefs.SetFloat("rz", estado.transform.rotation.z);
    }

    public static void Cargar(MonoBehaviour componente)
    {
        Estado estado = (Estado) componente;
        estado.posX = PlayerPrefs.GetFloat("px");
        estado.posY = PlayerPrefs.GetFloat("py");
        estado.posZ = PlayerPrefs.GetFloat("pz");

        estado.roX = PlayerPrefs.GetFloat("rx");
        estado.roY = PlayerPrefs.GetFloat("ry");
        estado.roZ = PlayerPrefs.GetFloat("rz");
    }
}