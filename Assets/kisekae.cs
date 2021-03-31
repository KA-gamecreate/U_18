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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("MONEY") == 1)
        {
            ribon.SetActive(true);
        }
        if (PlayerPrefs.GetInt("MONEY") == 2)
        {
            sen.SetActive(true);
        }
        if (PlayerPrefs.GetInt("MONEY") == 3)
        {
            hat.SetActive(true);
        }
        if (PlayerPrefs.GetInt("MONEY") == 4)
        {
            himawari.SetActive(true);
        }
        if (PlayerPrefs.GetInt("MONEY") == 5)
        {
            orange.SetActive(true);
        }
        if (PlayerPrefs.GetInt("MONEY") == 6)
        {
            happa.SetActive(true);
        }
        if (PlayerPrefs.GetInt("MONEY") == 7)
        {
            cat.SetActive(true);
        }
        if (PlayerPrefs.GetInt("MONEY") == 8)
        {
            hiyoko.SetActive(true);
        }
        if (PlayerPrefs.GetInt("MONEY") == 9)
        {
            tensi.SetActive(true);
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
        PlayerPrefs.SetInt("KIGAE",1);
        PlayerPrefs.Save();
    }
    public void Sen()
    {
        PlayerPrefs.SetInt("KIGAE", 2);
        PlayerPrefs.Save();
    }
    public void Hat()
    {
        PlayerPrefs.SetInt("KIGAE", 3);
        PlayerPrefs.Save();
    }
    public void Himawari()
    {
        PlayerPrefs.SetInt("KIGAE", 4);
        PlayerPrefs.Save();
    }
    public void Orange()
    {
        PlayerPrefs.SetInt("KIGAE", 5);
        PlayerPrefs.Save();
    }
    public void Happa()
    {
        PlayerPrefs.SetInt("KIGAE", 6);
        PlayerPrefs.Save();
    }
    public void Cat()
    {
        PlayerPrefs.SetInt("KIGAE", 7);
        PlayerPrefs.Save();
    }
    public void Hiyoko()
    {
        PlayerPrefs.SetInt("KIGAE", 8);
        PlayerPrefs.Save();
    }
    public void Tensi()
    {
        PlayerPrefs.SetInt("KIGAE", 9);
        PlayerPrefs.Save();
    }
}
