using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class WebLeer : WebEscribir
{
    [SerializeField] private Text txtUserView = null;
    
    [ContextMenu("LeerJson")]
    // Start is called before the first frame update
    public void LeerJson()
    {
        StartCoroutine(CorutinaLeerJson());
    }

    public IEnumerator CorutinaLeerJson()
    {
        UnityWebRequest web = UnityWebRequest.Get("https://spacetripmovil.000webhostapp.com/Game/createuser.txt");
        yield return web.SendWebRequest();
        if (!web.isNetworkError && !web.isHttpError)
        {
            datos = JsonUtility.FromJson<datosWeb>(web.downloadHandler.text);
            txtUserView.text = datos.user;

        }
        else
        {
            Debug.LogError("Error al consultar datos");
        }
    }
    void Awake()
    {
        LeerJson();
    }
}
