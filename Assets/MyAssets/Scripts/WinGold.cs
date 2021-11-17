using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinGold : MonoBehaviour
{
    public Text Gold;
    public int txtGold;

    LogicaVidaViruz lv;

    // Start is called before the first frame update
    void Start()
    {
        txtGold = 0;
    }
    void Update()
    {
        txtGold += 10;
        Gold.text = txtGold.ToString();
    }
}