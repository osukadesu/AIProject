using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinGold : MonoBehaviour
{
    public Text Gold;

    public int txtGold = 0;

    LogicaVidaViruz lv;

    public void updategold()
    {
        if (lv.gameObject.tag == "Virus" && lv.vidactual == 0)
        {
            txtGold += 10;
            Gold.text = txtGold.ToString();
        }
    }
}
