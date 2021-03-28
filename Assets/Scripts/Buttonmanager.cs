using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttonmanager : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip sound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


    }

    public void Tutorial()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(sound);
        Invoke("Tutorialidou", 1.0f);

    }
    public void Tutorialidou()
    {
        SceneManager.LoadScene("tutorial");
    }
    public void Shop()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(sound);
        Invoke("Shopidou",1.0f);
       
    }
    public void Shopidou()
    {
        SceneManager.LoadScene("shop");
    }
    public void StageA()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(sound);
        Invoke("StageAidou", 1.0f);
    }
    public void StageAidou()
    {
        SceneManager.LoadScene("sentou2");
    }
    public void StageB()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(sound);
        Invoke("StageBidou", 1.0f);
    }
    public void StageBidou()
    {
        SceneManager.LoadScene("sentou3");
    }
    public void StageC()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(sound);
        Invoke("StageCidou", 1.0f);
    }
    public void StageCidou()
    {
        SceneManager.LoadScene("sentou4");
    }
    public void StageD()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(sound);
        Invoke("StageDidou", 1.0f);
    }
    public void StageDidou()
    {
        SceneManager.LoadScene("sentou5");
    }
    public void Menu()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(sound);
        Invoke("Menuidou", 1.0f);
    }
    public void Menuidou()
    {
        SceneManager.LoadScene("selectmenu");
    }
    public void Title()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(sound);
        Invoke("Titleidou", 1.0f);
    }
    public void Titleidou()
    {
        SceneManager.LoadScene("title");
    }
    public void Offline()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(sound);
        Invoke("Offlineidou", 1.0f);
    }
    public void Offlineidou()
    {
        SceneManager.LoadScene("sentou_test");
    }
}
