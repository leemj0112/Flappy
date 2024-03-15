using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float Speed = 1.3f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position += Vector3.left * Speed * Time.deltaTime;
    }
}
