using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skill : MonoBehaviour
{
    public GameObject pl1;
    public GameObject skill2;
    public GameObject pl2;
    public GameObject en2;
    public GameObject button1;
    public GameObject button2;
    StageScript script;
    GameObject stagemaker;
    AudioSource audioSource;
    public AudioClip sound;


    // Start is called before the first frame update
    void Start()
    {
        stagemaker = GameObject.Find("stagemaker");

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NoplSkill()
    {
        pl1.SetActive(true);
    }
    public void Twomove()
    {
        skill2.SetActive(true);
        button2.SetActive(false);
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(sound);
    }
    public void PlSkillA()
    {
        pl2.SetActive(true);
    }
    public void EnSkillA ()
    {
        en2.SetActive(true);
    }
    
    public void Yasumi()
    {
        audioSource = GetComponent<AudioSource>();
        stagemaker.GetComponent<StageScript>().playerTurn = false;
        button1.SetActive(false);
        audioSource.PlayOneShot(sound);
    }

}
