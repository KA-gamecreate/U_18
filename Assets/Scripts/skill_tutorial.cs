using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skill_tutorial : MonoBehaviour
{
    GameObject stagemaker;
    AudioSource audioSource;
    public AudioClip sound;
    public GameObject button1;
    public GameObject Wcanvas;
    // Start is called before the first frame update
    void Start()
    {
        stagemaker = GameObject.Find("stagemaker");
        Debug.Log(stagemaker);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Rest()
    {
        audioSource = GetComponent<AudioSource>();
        stagemaker.GetComponent<player3>().playerTurn = false;
        button1.SetActive(false);
        Wcanvas.SetActive(true);
        audioSource.PlayOneShot(sound);
        stagemaker.GetComponent<player3>().Enemymove();
      }
}
