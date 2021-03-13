using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class player2 : MonoBehaviour
{
    StageScript script;
    GameObject stagemaker;
    
    // Start is called before the first frame update
    void Start()
    {
        stagemaker = GameObject.Find("stagemaker");
        script = stagemaker.GetComponent<StageScript>();
        bool plturn = stagemaker.GetComponent<StageScript>().playerTurn;
    }

    // Update is called once per frame
    void Update()
    {
        
    }



}
