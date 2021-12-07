using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WebEscribir : MonoBehaviour
{
    [SerializeField] private InputField inputUser = null;
    [SerializeField] private InputField inputPass = null;

    [System.Serializable]
    public struct datosWeb
    {
        public string user;
        public string pass;
    }
    public datosWeb datos;

    [ContextMenu("EscribirJson")]
    // Start is called before the first frame update
    public void EscribirJson()
    {
        StartCoroutine(CorutinaEscribirJson());
    }

    public void AutoLeer()
    {
        datos.user = inputUser.text;
        datos.pass = inputPass.text;
    }
    private IEnumerator CorutinaEscribirJson()
    {
        AutoLeer();
        WWWForm form = new WWWForm();
        form.AddField("archivo", "createuser");
        form.AddField("texto", JsonUtility.ToJson(datos));
        UnityWebRequest web = UnityWebRequest.Post("https://spacetripmovil.000webhostapp.com/Game/escribir.php", form);
        yield return web.SendWebRequest();
        if (!web.isNetworkError && !web.isHttpError)
        {
            Debug.Log(web.downloadHandler.text);
        }
        else
        {
            Debug.LogError("Error al registrar datos");
        }
    }

    public void changeScene2()
    {
        SceneManager.LoadScene(1);
    }
}
