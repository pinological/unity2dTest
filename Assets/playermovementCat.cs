using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovementCat : MonoBehaviour
{
     Rigidbody2D playerRb;
     public float playerSpeed = 5f;
    void Start()
    {
       playerRb = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 playerMovement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        playerRb.velocity = playerMovement * playerSpeed;
    }
}
