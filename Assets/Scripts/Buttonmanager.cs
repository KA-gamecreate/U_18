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
    public void Shop()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(sound);
        Invoke("shopidou",1.0f);
       
    }
    public void Shopidou()
    {
        SceneManager.LoadScene("shop");
    }
    public void Tutorialidou()
    {
        SceneManager.LoadScene("tutorial");
    }
}
