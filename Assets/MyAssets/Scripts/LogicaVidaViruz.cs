using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicaVidaViruz : MonoBehaviour
{
    public int vidamax = 100;

    public float vidactual, timehit = 0.5f;
    public Image imagenvida;
    public bool hit = false;
    // Start is called before the first frame update
    void Start()
    {
        vidactual = vidamax;
    }

    // Update is called once per frame
    public void Update()
    {
        updatevida();
        DeathVirus();

    }

    public void DeathVirus()
    {
        if (vidactual <= 0)
        {
            Destroy(gameObject, 0.2f);
        }
    }

    public void updatevida()
    {
        imagenvida.fillAmount = vidactual / vidamax;
    }

    public void RestarVida(int cantidad)
    {
        if (!hit && vidactual > 0)
        {
            vidactual -= cantidad;
            StartCoroutine(Hitime());
        }

    }
    IEnumerator Hitime()
    {
        hit = true;
        yield return new WaitForSeconds(timehit);
        hit = false;
    }
}
