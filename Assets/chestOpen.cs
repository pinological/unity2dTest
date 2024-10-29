using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chestOpen : MonoBehaviour
{
    Animator boxAnimation;
    gameManagerScript gameManager;

    private void Start()
    {
        boxAnimation = GetComponent<Animator>();
        gameManager = FindAnyObjectByType<gameManagerScript>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
            boxAnimation.SetBool("openBox", true);
            Invoke("endGame",1f);

        }
    }

    void endGame() {
        gameManager.isAllCollected();
    }


    }
