using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Scorekeeper : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    private int coinCount = 0;
   

    public void CollectCoin() {

        coinCount++;
        UpdateUI();
    }

    private void UpdateUI()
    {
        if (coinText != null)
        {
            coinText.text = "coin:" + coinCount.ToString();
        }
    }
}

