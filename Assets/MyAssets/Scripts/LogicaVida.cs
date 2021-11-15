using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicaVida : MonoBehaviour
{
    public int vidamax = 100;

    public float vidactual, timehit = 1f;
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
        if (vidactual <= 0)
        {
            gameObject.SetActive(false);
            
            Gameover();
        }

    }
    public void Gameover()
    {
        SceneManager.LoadScene(1);
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
