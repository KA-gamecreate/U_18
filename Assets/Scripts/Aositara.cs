﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aositara : MonoBehaviour
{

    GameObject woj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            woj.SetActive(true);
        }
    }
}
