using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinManager : MonoBehaviour
{
    gameManagerScript gameManager;

    private void Start()
    {
        gameManager = FindAnyObjectByType<gameManagerScript>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) {

            gameManager.coinAdder();
            Destroy(gameObject);
        }
    }
}
