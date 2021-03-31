using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skill2 : MonoBehaviour
{
    public GameObject pl1;
    public GameObject skill2;
    public GameObject skill3;
    public GameObject pl2;
    public GameObject en2;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;

    StageScript script;
    GameObject stagemaker;
    AudioSource audioSource;
    public AudioClip sound;


    // Start is called before the first frame update
    void Start()
    {
        stagemaker = GameObject.Find("stagemaker");
        Debug.Log(stagemaker);

    }

    // Update is called once per frame
    void Update()
    {
        if (stagemaker.GetComponent<StageScript>().playerTurn == true)
        {
            button4.SetActive(false);
            button3.SetActive(true);
        }
        if (stagemaker.GetComponent<StageScript>().playerTurn == false)
        {
            button3.SetActive(false);
            button4.SetActive(true);
        }
        if (stagemaker.GetComponent<StageScript>().enemy.activeSelf == false)
        {
            button4.SetActive(false);
            Debug.Log("は？");
        }
        if (stagemaker.GetComponent<StageScript>().player.activeSelf == false)
        {
            button3.SetActive(false);
            Debug.Log("お？");
        }
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
    public void EnSkillA()
    {
        en2.SetActive(true);
    }

    public void Yasumi()
    {
        audioSource = GetComponent<AudioSource>();
        stagemaker.GetComponent<kyukyo>().playerTurn = false;
        stagemaker.GetComponent<kyukyo>().yourturn.SetActive(false);
        stagemaker.GetComponent<kyukyo>().enemyturn.SetActive(true);
        button1.SetActive(false);
        audioSource.PlayOneShot(sound);
    }
    public void Yasumitwo()
    {
        button4.SetActive(true);
        button3.SetActive(false);
        stagemaker.GetComponent<StageScript>().playerTurn = false;
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(sound);

    }
    public void Yasumithree()
    {
        button3.SetActive(true);
        button4.SetActive(false);
        stagemaker.GetComponent<StageScript>().playerTurn = true;
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(sound);
    }

}
