using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gatya : MonoBehaviour
{
    public GameObject SkillShop;
    public GameObject Menu;
    public GameObject KisekaeShop;
    public GameObject GatyaShop;
    public GameObject[] Picture;
    public bool[] Result;
    public float[] Gatya = new float[6];
    public float sum;
    public float RANDOM;
    

    // Start is called before the first frame update
    void Start()
    {
        Gatya[0] = 0.2f;
        Gatya[1] = 0.1f;
        Gatya[2] = 0.1f;
        Gatya[3] = 0.3f;
        Gatya[4] = 0.2f;
        Gatya[5] = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Skillshop()
    {
        SkillShop.SetActive(true);
        Menu.SetActive(false);
    }
    public void Kisekaeshop()
    {
        KisekaeShop.SetActive(true);
        Menu.SetActive(false);
    }
    public void Back()
    {
        KisekaeShop.SetActive(false);
        SkillShop.SetActive(false);
        GatyaShop.SetActive(false);
        Menu.SetActive(true);
    }
    public void Gatyashop()
    {
        GatyaShop.SetActive(true);
        Menu.SetActive(false);
    }
    public void Oncegatya()
    {
        if (PlayerPrefs.GetInt("SCORE") < 200)
        {
            Debug.Log("マネーが足りないよ！");
        }
        else 
        {
            RANDOM = Random.Range(0f,1.0f);
            sum = 0f;

            Debug.Log("a");
            Debug.Log("Length:" + Gatya[1]);
            for (int i = 0; i < 6; i++)
            {
                Debug.Log(sum);
                sum += Gatya[i];
                if(sum > RANDOM)
                {
                    //return i;
                    Debug.Log(RANDOM);
                    Debug.Log(sum);
                }
            }
            PlayerPrefs.SetInt("SCORE", PlayerPrefs.GetInt("SCORE") - 200);
            PlayerPrefs.Save();
            Invoke("GatyaResult", 0.2f);
            
        }
        //return 0;
    }
 
    public void GatyaResult()
    {
        

    }
}
