using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skill_Select : MonoBehaviour
{
    int Skillnum;
    public GameObject Playerbutton;
    StageScript script;
    public GameObject stagemaker;
    AudioSource audioSource;
    public AudioClip sound;
    public GameObject Spanel;
   

    


    // Start is called before the first frame update
    void Start()
    {
        Playerbutton.SetActive(false);
        Debug.Log(stagemaker);
        Skillnum = 0;

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Skillnum);
        if(Skillnum == 0)
        {
            
        }
        if(Skillnum == 1)
        {
             if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S))
            {
                stagemaker.GetComponent<player1>().playerTurn = true;
                stagemaker.GetComponent<player1>().CancelInvoke();
                
                Skillnum = 0;
            }
        }
        if (Skillnum == 2)
        {
            if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S))
            {
                stagemaker.GetComponent<player1>().playerTurn = true;
                stagemaker.GetComponent<player1>().CancelInvoke();
            }
        }
        if (stagemaker.GetComponent<StageScript>().playerTurn == true)
        {
            Playerbutton.SetActive(true);
        }
        if (stagemaker.GetComponent<StageScript>().playerTurn == false)
        {
            Playerbutton.SetActive(false);
        }
        
    }
    public void NoplSkill()
    {
        Debug.Log("何もないが？w");
        Spanel.SetActive(false);
        stagemaker.SetActive(true);
        PlayerPrefs.SetInt("Playerskill",0);


    }
    
    public void SkillA()
    {
        //一休み一回だけ
        stagemaker.GetComponent<StageScript>().playerTurn = false;
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(sound);
        Playerbutton.SetActive(false);
    }
    public void SkillB()
    {
        //二回行動一回だけ
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(sound);
        Playerbutton.SetActive(false);
        Skillnum = 1;
    }
    public void SkillC()
    {
        //二回行動
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(sound);
        Skillnum = 2;
    }
    public void SkillAs()
    {
        Spanel.SetActive(false);
        stagemaker.SetActive(true);
    }
    public void SkillBs()
    {
        Spanel.SetActive(false);
        stagemaker.SetActive(true);
    }
    public void SkillCs()
    {
        Spanel.SetActive(false);
        stagemaker.SetActive(true);
    }
}
