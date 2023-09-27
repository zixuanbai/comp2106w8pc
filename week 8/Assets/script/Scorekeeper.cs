using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Scorekeeper : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI cointText2;
    private int coinCount = 0;
    private int playerOneCoin = 0;
    private int playerTwoCoin = 0;

    public void CollectCoin(bool player) 
    {
        if (player)
        {
            playerOneCoin++;
            UpdateUI();
        }
        else
        {
            playerTwoCoin++;
            UpdateUI();
        }

    }

    private void UpdateUI()
    {
        if (coinText != null && cointText2 != null)
        {
            coinText.text = "coin:" + playerOneCoin.ToString();
            cointText2.text = "coin:" + playerTwoCoin.ToString();
        }
    }
}

