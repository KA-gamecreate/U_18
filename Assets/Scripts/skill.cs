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
    // Start is called before the first frame update
    void Start()
    {
        
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
}
