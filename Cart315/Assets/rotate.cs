﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{

    public float rotate_speed = 1.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetButton("Fire1"))
        this.transform.Rotate(0,rotate_speed,0);
    }
}
