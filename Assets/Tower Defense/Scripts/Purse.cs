using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Purse : MonoBehaviour
{
    int playerCoins = 0;
    public GameObject coinsText;

    private void Start()
    {
        coinsText.GetComponent<TextMeshProUGUI>().SetText(String.Format("{0:0000}", playerCoins));
    }

    public void increaseCoinCount()
    {
        playerCoins += 10;
        Debug.Log("Player has " + playerCoins + " coins.");
        coinsText.GetComponent<TextMeshProUGUI>().text = String.Format("{0:0000}", playerCoins);
    }

    public int getCoinCount()
    {
        return playerCoins;
    }

    public void purchaseTower()
    {
        playerCoins -= 20;
        Debug.Log("Player has purchased a tower " + playerCoins + " coins left.");
        coinsText.GetComponent<TextMeshProUGUI>().text = String.Format("{0:0000}", playerCoins);
    }
}
