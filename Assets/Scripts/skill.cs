using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skill : MonoBehaviour
{
    public GameObject pl1;
    public GameObject en1;
    public GameObject pl2;
    public GameObject en2;
    public GameObject yasumi;
    StageScript script;
    GameObject stagemaker;
    AudioSource audioSource;
    public AudioClip sound;


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
    public void NoplSkill()
    {
        pl1.SetActive(true);
    }
    public void NoenSkill()
    {
        en1.SetActive(true);
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
        yasumi.SetActive(false);
        pl2.SetActive(false);
        audioSource.PlayOneShot(sound);
    }

}
