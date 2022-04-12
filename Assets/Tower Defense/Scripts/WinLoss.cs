using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WinLoss : MonoBehaviour
{
    public GameObject winLossText;
    string winLoss;

    void Start()
    {
        winLoss = PlayerPrefs.GetString("Win/Loss");
        if(winLoss == "You win!")
        {
            winLossText.GetComponent<TextMeshProUGUI>().SetText(winLoss);
            winLossText.GetComponent<TextMeshProUGUI>().color = new Color32(0, 255, 0, 255);
        }
        else
        {
            winLossText.GetComponent<TextMeshProUGUI>().SetText(winLoss);
            winLossText.GetComponent<TextMeshProUGUI>().color = new Color32(255, 0, 0, 255);
        }
    }
}
