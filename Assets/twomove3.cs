﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class twomove3 : MonoBehaviour
{
    GameObject stagemaker;
    // Start is called before the first frame update
    void Start()
    {
        stagemaker = GameObject.Find("stagemaker");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S))
        {
            stagemaker.GetComponent<kyukyo2>().playerTurn = true;
            stagemaker.GetComponent<kyukyo2>().CancelInvoke();
            Destroy(this);
            Debug.Log("aaa");
        }
    }
}
