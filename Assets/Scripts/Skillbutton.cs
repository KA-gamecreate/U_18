using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Skillbutton : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject panel;
    public GameObject text;
    public GameObject button1_2;
    public GameObject button2_2;
    public GameObject Skill;
    public GameObject stagemaker;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void a()
        {
        button1.SetActive(false);
        button2.SetActive(false);
        button3.SetActive(false);
        panel.SetActive(false);
        text.SetActive(false);
        stagemaker.SetActive(true);
        Skill.SetActive(true);
    }
    public void Hojo()
    {
        button1.SetActive(false);
        button2.SetActive(false);
        button3.SetActive(false);
        panel.SetActive(false);
        text.SetActive(false);
        button1_2.SetActive(true);
        stagemaker.SetActive(true);
        Skill.SetActive(true);
    }
    public void Onsen()
    {
        button1.SetActive(false);
        button2.SetActive(false);
        button3.SetActive(false);
        panel.SetActive(false);
        text.SetActive(false);
        button2_2.SetActive(true);
        stagemaker.SetActive(true);
        Skill.SetActive(true);
    }

}
