using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kisekae : MonoBehaviour
{
    public GameObject cat;
    public GameObject happa;
    public GameObject sen;
    public GameObject hat;
    public GameObject himawari;
    public GameObject ribon;
    public GameObject hiyoko;
    public GameObject tensi;
    public GameObject orange;
    public GameObject change;
    public GameObject kigaeta;
    public GameObject[] gjArray = new GameObject[9];
    //表示するボタンをいれるだけのやつ



    // Start is called before the first frame update

    void Start()
    {
        for (int i = 0; i < shop.KisekaeOnOff.GetLength(0); i++)
        {
          if(PlayerPrefs.GetInt("MONEY" + i) == 1)
            {
                shop.Katta[i] = true;
                gjArray[i].SetActive(true);
               
            }
            else
            {
                shop.Katta[i] = false;
                gjArray[i].SetActive(false);
       
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < shop.KisekaeOnOff.Length; i++)
        {
            if (shop.Katta[i] == true)
            {
                gjArray[i].SetActive(true);
            }
            else
            {
                gjArray[i].SetActive(false);
            }
        }
    }
    public void Kisekae()
    {
        change.SetActive(true);
    }
    public void Kisekaeno()
    {
        change.SetActive(false);
    }
    public void Ribon()
    {
        kigaeta.SetActive(true);
        Invoke("Kigaenai", 1.0f);
        PlayerPrefs.SetInt("KIGAE",1);
      
        PlayerPrefs.Save();
    }
    public void Sen()
    {
        kigaeta.SetActive(true);
        Invoke("Kigaenai", 1.0f);
        PlayerPrefs.SetInt("KIGAE", 2);
      
        PlayerPrefs.Save();
    }
    public void Hat()
    {
        kigaeta.SetActive(true);
        Invoke("Kigaenai", 1.0f);
        PlayerPrefs.SetInt("KIGAE", 3);
       
        PlayerPrefs.Save();
    }
    public void Himawari()
    {
        kigaeta.SetActive(true);
        Invoke("Kigaenai", 1.0f);
        PlayerPrefs.SetInt("KIGAE", 4);
       
        PlayerPrefs.Save();
    }
    public void Orange()
    {
        kigaeta.SetActive(true);
        Invoke("Kigaenai", 1.0f);
        PlayerPrefs.SetInt("KIGAE", 5);
       
        PlayerPrefs.Save();
    }
    public void Happa()
    {
        kigaeta.SetActive(true);
        Debug.Log("kigaeta");
        Invoke("Kigaenai", 1.0f);
        PlayerPrefs.SetInt("KIGAE", 6);
      
        PlayerPrefs.Save();
    }
    public void Cat()
    {
        kigaeta.SetActive(true);
        Invoke("Kigaenai", 1.0f);
        PlayerPrefs.SetInt("KIGAE", 7);
      
        PlayerPrefs.Save();
    }
    public void Hiyoko()
    {
        kigaeta.SetActive(true);
        Invoke("Kigaenai", 1.0f);
        PlayerPrefs.SetInt("KIGAE", 8);
      
        PlayerPrefs.Save();
    }
    public void Tensi()
    {
        kigaeta.SetActive(true);
        Invoke("Kigaenai", 1.0f);
        PlayerPrefs.SetInt("KIGAE", 9);
     
        PlayerPrefs.Save();
    }
    public void Kigaenai()
    {
        kigaeta.SetActive(false);
    }
}
