using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameManagerScript : MonoBehaviour
{
    int coin = 0;
    public TextMeshProUGUI textScore;
    public int numberOfCoin = 3;

    public GameObject pannelEnd;

    public void coinAdder() {
        coin++;
        textScore.text = "Coin : " + coin;
    }

    public void isAllCollected() {
        if (coin == numberOfCoin) {
            Time.timeScale = 0f;
            pannelEnd.SetActive(true);
        }
    }
}
