using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncionGC : MonoBehaviour
{
public Estado estado;

    void Update(){
        if (Input.GetKeyDown(KeyCode.G))
        {
            Guardar();
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                Cargar();
            }
        }
    }
   public  void Guardar()
   {
       GestorEstado.Guardar(estado);
   }
     public  void Cargar()
   {
       GestorEstado.Cargar(estado);
   }
}