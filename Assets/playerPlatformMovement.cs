using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class playerPlatformMovement : MonoBehaviour
{
    public float playermovementSpeed = 5f;
    public float jumpPower = 5f;
    public LayerMask layerM;
    public Transform gCheckTrans;

    Animator animatorContoller;

    Rigidbody2D rbbody;
    void Start()
    {
        rbbody = GetComponent<Rigidbody2D>();
        animatorContoller = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        rbbody.velocity = new Vector2( Input.GetAxis("Horizontal") * playermovementSpeed, rbbody.velocity.y);


        //jump

        if (Input.GetButton("Jump") && groundcheck())
        {
            //rbbody.AddForce(Vector2.up * jumpPower);
            rbbody.velocity = new Vector2(rbbody.velocity.x, jumpPower);
        }

        if (groundcheck())
        {
            if (Math.Abs(rbbody.velocity.x) > 0)
            {
                animatorContoller.SetInteger("switchAni", 1);
            }
            else
            {
                animatorContoller.SetInteger("switchAni", 0);
            }

        }
        else
        {
            animatorContoller.SetInteger("switchAni", 2);
        }

        if (rbbody.velocity.x < 0)
        {

            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        if (rbbody.velocity.x > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);

        }
    }

    bool groundcheck()
    {
        return Physics2D.OverlapCapsule(new Vector2(gCheckTrans.position.x, gCheckTrans.position.y), new Vector2(0.2f, 0.2f), CapsuleDirection2D.Vertical, 0, layerM);
    }
}
