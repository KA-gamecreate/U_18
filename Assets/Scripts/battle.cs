using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battle : MonoBehaviour
{
    public bool playerTurn;



    // Use this for initialization
    void Start()
    {
        playerTurn = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (playerTurn == true)
        {
           if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Debug.Log("me");
                playerTurn = false;
            }

        }
        if (playerTurn == false)
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            { 
                 Debug.Log("you");
                 playerTurn = true;
            }
        }
    }
}
