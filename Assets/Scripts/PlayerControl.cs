﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 10.0f;
    const float horizontalBoundary = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > horizontalBoundary)
        {
            transform.position = new Vector3(horizontalBoundary,transform.position.y,transform.position.z);
        }
        if(transform.position.x < -horizontalBoundary)
        {
            transform.position = new Vector3(-horizontalBoundary, transform.position.y, transform.position.z);
        }
        float horizontal = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * horizontal * Time.deltaTime);
    }
}
