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
    float[] Gatya = {0.2f,0.1f,0.1f,0.3f,0.2f,0.1f};
    public float sum;
    public float RANDOM;
    

    // Start is called before the first frame update
    void Start()
    {
        
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

            
            for (int i = 0; i < Gatya.Length; i++)
            {

                sum += Gatya[i];
                if(sum > RANDOM)
                {
                    //return i;
                    Debug.Log("RANDOM"+RANDOM);
                    Debug.Log("sum"+sum);
                    break;
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
