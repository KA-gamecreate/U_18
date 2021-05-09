using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class shop : MonoBehaviour
{
    //シーンまたいで着せ替えの持ってるかのオンオフ取得
    public static int[] KisekaeOnOff = {0,0,0,0,0,0,0,0,0};
    //falseで買ってないよってこと
    public static bool[] Katta = {false, false,false, false, false, false, false, false, false};
    public Text moneytext;
    public GameObject cat;
    public GameObject happa;
    public GameObject sen;
    public GameObject hat;
    public GameObject himawari;
    public GameObject ribon;
    public GameObject hiyoko;
    public GameObject tensi;
    public GameObject orange;
    public GameObject catb;
    public GameObject happab;
    public GameObject senb;
    public GameObject hatb;
    public GameObject himawarib;
    public GameObject ribonb;
    public GameObject hiyokob;
    public GameObject tensib;
    public GameObject orangeb;
    // Start is called before the first frame update
    void Start()
    { 
        moneytext.text = "所持金：" + PlayerPrefs.GetInt("SCORE");
        for (int i = 0; i < KisekaeOnOff.Length; i++)
        {
            if (PlayerPrefs.GetInt("MONEY" + i) == 1)
            {
                Katta[i] = true;
                
            }
            else
            {
                Katta[i] = false;

            }
        }
        }

    // Update is called once per frame
    void Update()
    {
        
        moneytext.text = "所持金：" + PlayerPrefs.GetInt("SCORE");
        if (Input.GetKeyDown(KeyCode.L))
        {
            PlayerPrefs.SetInt("SCORE", PlayerPrefs.GetInt("SCORE") + 10000);
            PlayerPrefs.Save();
        }


        if (PlayerPrefs.GetInt("SCORE") < 200)
        {
            ribonb.SetActive(false);
            happab.SetActive(false);
            catb.SetActive(false);
            tensib.SetActive(false);
            senb.SetActive(false);
            himawarib.SetActive(false);
            hatb.SetActive(false);
            hiyokob.SetActive(false);
            orangeb.SetActive(false);
        }
        if (PlayerPrefs.GetInt("SCORE") >= 200)
        {
            ribonb.SetActive(true);
            happab.SetActive(false);
            catb.SetActive(false);
            tensib.SetActive(false);
            senb.SetActive(false);
            himawarib.SetActive(false);
            hatb.SetActive(false);
            hiyokob.SetActive(false);
            orangeb.SetActive(false);
        }
        if (PlayerPrefs.GetInt("SCORE") >= 300)
        {
            ribonb.SetActive(true);
            happab.SetActive(false);
            catb.SetActive(false);
            tensib.SetActive(false);
            senb.SetActive(true);
            himawarib.SetActive(false);
            hatb.SetActive(false);
            hiyokob.SetActive(false);
            orangeb.SetActive(false);
        }
        if (PlayerPrefs.GetInt("SCORE") >= 400)
        {
            ribonb.SetActive(true);
            happab.SetActive(false);
            catb.SetActive(false);
            tensib.SetActive(false);
            senb.SetActive(true);
            himawarib.SetActive(false);
            hatb.SetActive(true);
            hiyokob.SetActive(false);
            orangeb.SetActive(false);
        }
        if (PlayerPrefs.GetInt("SCORE") >= 500)
        {
            ribonb.SetActive(true);
            happab.SetActive(false);
            catb.SetActive(false);
            tensib.SetActive(false);
            senb.SetActive(true);
            himawarib.SetActive(true);
            hatb.SetActive(true);
            hiyokob.SetActive(false);
            orangeb.SetActive(false);
        }
        if (PlayerPrefs.GetInt("SCORE") >= 600)
        {
            ribonb.SetActive(true);
            happab.SetActive(false);
            catb.SetActive(false);
            tensib.SetActive(false);
            senb.SetActive(true);
            himawarib.SetActive(true);
            hatb.SetActive(true);
            hiyokob.SetActive(false);
            orangeb.SetActive(true);
        }
        if (PlayerPrefs.GetInt("SCORE") >= 700)
        {
            ribonb.SetActive(true);
            happab.SetActive(true);
            catb.SetActive(false);
            tensib.SetActive(false);
            senb.SetActive(true);
            himawarib.SetActive(true);
            hatb.SetActive(true);
            hiyokob.SetActive(false);
            orangeb.SetActive(true);
        }
        if (PlayerPrefs.GetInt("SCORE") >= 800)
        {
            ribonb.SetActive(true);
            happab.SetActive(true);
            catb.SetActive(true);
            tensib.SetActive(false);
            senb.SetActive(true);
            himawarib.SetActive(true);
            hatb.SetActive(true);
            hiyokob.SetActive(false);
            orangeb.SetActive(true);
        }
        if (PlayerPrefs.GetInt("SCORE") >= 900)
        {
            ribonb.SetActive(true);
            happab.SetActive(true);
            catb.SetActive(true);
            tensib.SetActive(false);
            senb.SetActive(true);
            himawarib.SetActive(true);
            hatb.SetActive(true);
            hiyokob.SetActive(true);
            orangeb.SetActive(true);
        }
        if (PlayerPrefs.GetInt("SCORE") >= 1000)
        {
            ribonb.SetActive(true);
            happab.SetActive(true);
            catb.SetActive(true);
            tensib.SetActive(true);
            senb.SetActive(true);
            himawarib.SetActive(true);
            hatb.SetActive(true);
            hiyokob.SetActive(true);
            orangeb.SetActive(true);
        }
    }
    public void Cat()
    {
        cat.SetActive(true);
    }
    public void Catbuy()
    {
        PlayerPrefs.SetInt("SCORE", PlayerPrefs.GetInt("SCORE") -800);

        //配列の、該当箇所を0->1に変更する
      
        Katta[6] = true;
        PlayerPrefs.Save();
        cat.SetActive(false);
    }
    public void Happa()
    {
        happa.SetActive(true);
    }
    public void Happabuy()
    {
        PlayerPrefs.SetInt("SCORE", PlayerPrefs.GetInt("SCORE") - 700);
       
        Katta[5] = true;
        PlayerPrefs.Save();
        happa.SetActive(false);
    }
    public void Sen()
    {
        sen.SetActive(true);
    }
    public void Senbuy()
    {
        PlayerPrefs.SetInt("SCORE", PlayerPrefs.GetInt("SCORE") - 300);
        
        Katta[1] = true;
        PlayerPrefs.Save();
        sen.SetActive(false);
    }
    public void Hat()
    {
        hat.SetActive(true);
    }
    public void Hatbuy()
    {
        PlayerPrefs.SetInt("SCORE", PlayerPrefs.GetInt("SCORE") - 400);
       
        Katta[2] = true;
        PlayerPrefs.Save();
        hat.SetActive(false);
    }
    public void Himawari()
    {
        himawari.SetActive(true);
    }
    public void Himawaribuy()
    {
        PlayerPrefs.SetInt("SCORE", PlayerPrefs.GetInt("SCORE") - 500);
        
        Katta[3] = true;
        PlayerPrefs.Save();
        himawari.SetActive(false);
    }
    public void Ribon()
    {
        ribon.SetActive(true);
    }
    public void Ribonbuy()
    {
        PlayerPrefs.SetInt("SCORE", PlayerPrefs.GetInt("SCORE") - 200);
       
        Katta[0] = true;
        PlayerPrefs.Save();
        ribon.SetActive(false);
    }
    public void Tensi()
    {
        tensi.SetActive(true);
    }
    public void Tensibuy()
    {
        PlayerPrefs.SetInt("SCORE", PlayerPrefs.GetInt("SCORE") - 1000);
        
        Katta[8] = true;
        PlayerPrefs.Save();
        tensi.SetActive(false);
    }
    public void Hiyoko()
    {
        hiyoko.SetActive(true);
    }
    public void Hiyokobuy()
    {
        PlayerPrefs.SetInt("SCORE", PlayerPrefs.GetInt("SCORE") - 900);
        
        Katta[7] = true;
        PlayerPrefs.Save();
        hiyoko.SetActive(false);
    }
    public void Orange()
    {
        orange.SetActive(true);
    }
    public void Orangebuy()
    {
        PlayerPrefs.SetInt("SCORE", PlayerPrefs.GetInt("SCORE") - 600);
       
        Katta[4] = true;
        PlayerPrefs.Save();
        orange.SetActive(false);
    }
    public void Riboncancel()
    {
        ribon.SetActive(false);
        
    }
    public void Hatcancel()
    {
        hat.SetActive(false);
    }
    public void Catcancel()
    {
        cat.SetActive(false);
    }
    public void Sencancel()
    {
        sen.SetActive(false);
    }
    public void Happacancel()
    {
        happa.SetActive(false);
    }
    public void Himawaricancel()
    {
        himawari.SetActive(false);
    }
    public void Orangecancel()
    {
        orange.SetActive(false);
    }
    public void Hiyokocancel()
    {
        hiyoko.SetActive(false);
    }
    public void Tensicancel()
    {
        tensi.SetActive(false);
    }
    public void TITLE()
    {
        for (int i = 0; i < KisekaeOnOff.Length; i++)
        {
            if (Katta[i] == true)
            {
                KisekaeOnOff[i] = 1;
            }
            else
            {
                KisekaeOnOff[i] = 0;
            }
        }
        for (int i = 0; i < KisekaeOnOff.Length; i++)
        {
            PlayerPrefs.SetInt("MONEY" + i, KisekaeOnOff[i]);
        }
            PlayerPrefs.Save();

       
        SceneManager.LoadScene("selectmenu");

    }
}
