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
    public GameObject[] gbArray = new GameObject[9];
    public Text moneytext;

    public Text detailtext;
    public GameObject gamen;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(PlayerPrefs.GetInt("MONEY"));
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
            gbArray[0].SetActive(false);
            gbArray[1].SetActive(false);
            gbArray[2].SetActive(false);
            gbArray[3].SetActive(false);
            gbArray[4].SetActive(false);
            gbArray[5].SetActive(false);
            gbArray[6].SetActive(false);
            gbArray[7].SetActive(false);
            gbArray[8].SetActive(false);
    

        }
        if (PlayerPrefs.GetInt("SCORE") >= 200)
        {
            gbArray[0].SetActive(true);
            gbArray[1].SetActive(false);
            gbArray[2].SetActive(false);
            gbArray[3].SetActive(false);
            gbArray[4].SetActive(false);
            gbArray[5].SetActive(false);
            gbArray[6].SetActive(false);
            gbArray[7].SetActive(false);
            gbArray[8].SetActive(false);

        }
        if (PlayerPrefs.GetInt("SCORE") >= 300)
        {
            gbArray[0].SetActive(true);
            gbArray[1].SetActive(true);
            gbArray[2].SetActive(false);
            gbArray[3].SetActive(false);
            gbArray[4].SetActive(false);
            gbArray[5].SetActive(false);
            gbArray[6].SetActive(false);
            gbArray[7].SetActive(false);
            gbArray[8].SetActive(false);

        }
        if (PlayerPrefs.GetInt("SCORE") >= 400)
        {
            gbArray[0].SetActive(true);
            gbArray[1].SetActive(true);
            gbArray[2].SetActive(true);
            gbArray[3].SetActive(false);
            gbArray[4].SetActive(false);
            gbArray[5].SetActive(false);
            gbArray[6].SetActive(false);
            gbArray[7].SetActive(false);
            gbArray[8].SetActive(false);

        }
        if (PlayerPrefs.GetInt("SCORE") >= 500)
        {
            gbArray[0].SetActive(true);
            gbArray[1].SetActive(true);
            gbArray[2].SetActive(true);
            gbArray[3].SetActive(true);
            gbArray[4].SetActive(false);
            gbArray[5].SetActive(false);
            gbArray[6].SetActive(false);
            gbArray[7].SetActive(false);
            gbArray[8].SetActive(false);

        }
        if (PlayerPrefs.GetInt("SCORE") >= 600)
        {
            gbArray[0].SetActive(true);
            gbArray[1].SetActive(true);
            gbArray[2].SetActive(true);
            gbArray[3].SetActive(true);
            gbArray[4].SetActive(true);
            gbArray[5].SetActive(false);
            gbArray[6].SetActive(false);
            gbArray[7].SetActive(false);
            gbArray[8].SetActive(false);

        }
        if (PlayerPrefs.GetInt("SCORE") >= 700)
        {
            gbArray[0].SetActive(true);
            gbArray[1].SetActive(true);
            gbArray[2].SetActive(true);
            gbArray[3].SetActive(true);
            gbArray[4].SetActive(true);
            gbArray[5].SetActive(true);
            gbArray[6].SetActive(false);
            gbArray[7].SetActive(false);
            gbArray[8].SetActive(false);
 
        }
        if (PlayerPrefs.GetInt("SCORE") >= 800)
        {
            gbArray[0].SetActive(true);
            gbArray[1].SetActive(true);
            gbArray[2].SetActive(true);
            gbArray[3].SetActive(true);
            gbArray[4].SetActive(true);
            gbArray[5].SetActive(true);
            gbArray[6].SetActive(true);
            gbArray[7].SetActive(true);
            gbArray[8].SetActive(false);

        }
        if (PlayerPrefs.GetInt("SCORE") >= 900)
        {
            gbArray[0].SetActive(true);
            gbArray[1].SetActive(true);
            gbArray[2].SetActive(true);
            gbArray[3].SetActive(true);
            gbArray[4].SetActive(true);
            gbArray[5].SetActive(true);
            gbArray[6].SetActive(true);
            gbArray[7].SetActive(true);
            gbArray[8].SetActive(true);

        }
        if (PlayerPrefs.GetInt("SCORE") >= 1000)
        {
            gbArray[0].SetActive(true);
            gbArray[1].SetActive(true);
            gbArray[2].SetActive(true);
            gbArray[3].SetActive(true);
            gbArray[4].SetActive(true);
            gbArray[5].SetActive(true);
            gbArray[6].SetActive(true);
            gbArray[7].SetActive(true);
            gbArray[8].SetActive(true);

        }
    }
    public void Cat()
    {
        gamen.SetActive(true);
        detailtext.text = "ねこ " +
        "可愛いは正義。" +
        "つまり猫は正義。".ToString();
   
    }
  
    public void Happa()
    {
        gamen.SetActive(true);
        detailtext.text = "葉っぱ " +
        "なんか生えてきた。" +
        "体に害はないよ。".ToString();
    }
    
    public void Sen()
    {
        gamen.SetActive(true);
        detailtext.text = "集中線 " +
        "主人公気分の味わえる線。" +
        "ハリネズミじゃないよ。".ToString();
    }
 
    public void Hat()
    {
        gamen.SetActive(true);
        detailtext.text = "ハット " +
        "マジシャンの被ってそうな帽子。" +
        "紳士っぽくなれるよ。".ToString();
    }
    
    public void Himawari()
    {
        gamen.SetActive(true);
        detailtext.text = "ひまわり " +
        "どこかの気難しい魔女の向日葵。" +
        "永久にしおれることは無い。".ToString();
    }
  
    public void Ribon()
    {
        gamen.SetActive(true);
        detailtext.text = "リボン " +
        "妙にギャルギャルしい。" +
        "近頃じゃ珍しいリボン。".ToString();
    }
   
    public void Tensi()
    {
        gamen.SetActive(true);
        detailtext.text = "天使 " +
        "可愛さが限界突破して天使になった。" +
        "空が飛べたりはしない。".ToString();
    }

    public void Hiyoko()
    {
        gamen.SetActive(true);
        detailtext.text = "ひよこ " +
        "お風呂に浮かべて遊ぶやつ。" +
        "何歳になっても楽しいよね。".ToString();    
    }

    public void Orange()
    {
        gamen.SetActive(true);
        detailtext.text = "みかん " +
        "ついつい食べすぎちゃうやつ。" +
        "体がオレンジになりそう。".ToString();
    }
    public void Kau()
    {
        if (detailtext.text == "みかん " +
        "ついつい食べすぎちゃうやつ。" +
        "体がオレンジになりそう。")
        {
            PlayerPrefs.SetInt("SCORE", PlayerPrefs.GetInt("SCORE") - 600);
            Katta[4] = true;
            PlayerPrefs.Save();
        }
        if(detailtext.text == "ひよこ " +
        "お風呂に浮かべて遊ぶやつ。" +
        "何歳になっても楽しいよね。")
        {
            PlayerPrefs.SetInt("SCORE", PlayerPrefs.GetInt("SCORE") - 900);

            Katta[7] = true;
            PlayerPrefs.Save();
        }
        if (detailtext.text == "天使 " +
        "可愛さが限界突破して天使になった。" +
        "空が飛べたりはしない。")
        {
            PlayerPrefs.SetInt("SCORE", PlayerPrefs.GetInt("SCORE") - 1000);

            Katta[8] = true;
            PlayerPrefs.Save();
        }
        if (detailtext.text == "リボン " +
        "妙にギャルギャルしい。" +
        "近頃じゃ珍しいリボン。")
        {
            PlayerPrefs.SetInt("SCORE", PlayerPrefs.GetInt("SCORE") - 200);

            Katta[0] = true;
            PlayerPrefs.Save();
        }
        if (detailtext.text == "ひまわり " +
        "どこかの気難しい魔女の向日葵。" +
        "永久にしおれることは無い。")
        {
            PlayerPrefs.SetInt("SCORE", PlayerPrefs.GetInt("SCORE") - 500);

            Katta[3] = true;
            PlayerPrefs.Save();
        }
        if (detailtext.text == "ハット " +
        "マジシャンの被ってそうな帽子。" +
        "紳士っぽくなれるよ。")
        {
            PlayerPrefs.SetInt("SCORE", PlayerPrefs.GetInt("SCORE") - 400);

            Katta[2] = true;
            PlayerPrefs.Save();
        }
        if (detailtext.text ==  "集中線 " +
        "主人公気分の味わえる線。" +
        "ハリネズミじゃないよ。")
        {
            PlayerPrefs.SetInt("SCORE", PlayerPrefs.GetInt("SCORE") - 300);

            Katta[1] = true;
            PlayerPrefs.Save();
        }
        if (detailtext.text == "葉っぱ " +
        "なんか生えてきた。" +
        "体に害はないよ。")
        {
            PlayerPrefs.SetInt("SCORE", PlayerPrefs.GetInt("SCORE") - 700);

            Katta[5] = true;
            PlayerPrefs.Save();
        }
        if (detailtext.text == "ねこ " +
        "可愛いは正義。" +
        "つまり猫は正義。")
        {

            PlayerPrefs.SetInt("SCORE", PlayerPrefs.GetInt("SCORE") - 800);
            Katta[6] = true;
            PlayerPrefs.Save();
        }


    }
    public void Kawanai()
    {
         detailtext.text = "".ToString();
         gamen.SetActive(false);
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
