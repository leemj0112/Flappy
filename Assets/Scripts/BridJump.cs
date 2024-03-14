using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridJump : MonoBehaviour
{
    Rigidbody2D rb;

    public float JumpPower;

    void Start()
    {
        rb  = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0)) 
        { 
        rb.velocity = Vector2.up * JumpPower;
        }
    }
}
