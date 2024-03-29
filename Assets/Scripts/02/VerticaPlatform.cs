﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticaPlatform : MonoBehaviour
{
    private PlatformEffector2D effector;
    public float waitTime;
    // Start is called before the first frame update
    void Start()
    {
        effector = GetComponent<PlatformEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (waitTime <= 0)
            {
                effector.rotationalOffset = 180f;
                waitTime = 0.2f;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
            Debug.Log(effector.rotationalOffset);
        }
        if (Input.GetButtonDown("Jump"))
        {
            effector.rotationalOffset = 0f;
        }
        
    }
}
