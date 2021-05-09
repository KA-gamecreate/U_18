using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kyukyo2 : MonoBehaviour
{

    public bool playerTurn;
    //public bool enemyTurn;
    int _width;
    int _height;
    int _outOfRange = -1;
    int[] _values = null;
    int enemynum = 0;
    public AudioClip sound1;
    public AudioClip sound2;
    public AudioClip sound3;
    public AudioClip sound4;
    AudioSource audioSource;
    public bool goal;
    int moveX;
    int moveY;
    public GameObject floorBlock;
    public GameObject wallBlock;
    public GameObject player;
    public GameObject enemy;
    public GameObject mygoal;
    public GameObject enemygoal;
    public GameObject goalcanvas;
    public GameObject goalcanvas2;
    public GameObject yourturn;
    public GameObject enemyturn;
    public GameObject ribon;
    public GameObject sen;
    public GameObject hat;
    public GameObject himawari;
    public GameObject orange;
    public GameObject happa;
    public GameObject cat;
    public GameObject hiyoko;
    public GameObject tensi;
    public int num;
    public int Width

    {
        get { return _width; }
    }
    public int Height
    {
        get { return _height; }
    }
    public void Create(int width, int height)
    {
        _width = width;
        _height = height;
        _values = new int[Width * Height];
    }
    public int ToIdx(int x, int y)
    {
        return x + (y * Width);
    }
    public bool IsOutOfRange(int x, int y)
    {
        if (x < 0 || x >= Width) { return true; }
        if (y < 0 || y >= Height) { return true; }
        return false;
    }
    public int Get(int x, int y)
    {
        if (IsOutOfRange(x, y))
        {
            return _outOfRange;
        }

        return _values[y * Width + x];
    }
    public void Set(int x, int y, int v)
    {
        if (IsOutOfRange(x, y))
        {
            return;
        }
        _values[y * Width + x] = v;
    }
    public void Dump()
    {

        for (int y = 0; y < Height; y++)
        {
            string s = "";
            for (int x = 0; x < Width; x++)
            {
                s += Get(x, y) + ",";
            }

        }
    }
    public int[,] stageArray = new int[8, 8]{
        //0は床 1は壁 2は自機 3は敵機
        {1,1,1,1,1,1,1,1},
        {1,1,0,0,0,0,3,1},
        {1,0,0,0,0,0,0,1},
        {1,0,0,0,0,0,0,1},
        {1,0,0,0,0,0,0,1},
        {1,0,0,0,0,0,0,1},
        {1,2,0,0,0,0,1,1},
        {1,1,1,1,1,1,1,1},
    };
    public int[,] goalArray = new int[8, 8]{
        //1は自陣 2は敵陣
        {0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,2,0},
        {0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0},
        {0,1,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0},
    };


    private void Start()
    {
        goal = false;
        audioSource = GetComponent<AudioSource>();
        playerTurn = true;
        yourturn.SetActive(true);
        enemyturn.SetActive(false);

        for (int i = 0; i < stageArray.GetLength(0); i++)
        {
            for (int j = 0; j < stageArray.GetLength(1); j++)
            {
                if (stageArray[i, j] == 1)
                {
                    Instantiate(wallBlock, new Vector3(i, j, -1), Quaternion.identity);
                }
                else
                {
                    Instantiate(floorBlock, new Vector3(i, j, -1), Quaternion.identity);

                }

            }
        }
        for (int i = 0; i < goalArray.GetLength(0); i++)
        {
            for (int j = 0; j < goalArray.GetLength(1); j++)
            {
                if (goalArray[i, j] == 1)
                {
                    Instantiate(mygoal, new Vector3(i, j, 0), Quaternion.identity);
                }
                else if (goalArray[i, j] == 2)
                {
                    Instantiate(enemygoal, new Vector3(i, j, 0), Quaternion.identity);

                }

            }
        }



    }
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

        if (Input.GetKeyDown(KeyCode.L))
        {
            PlayerPrefs.SetInt("SCORE", num = num + 10000);
            PlayerPrefs.Save();
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            PlayerPrefs.DeleteKey("SCORE");
            PlayerPrefs.Save();
        }
        Debug.Log(PlayerPrefs.GetInt("SCORE"));
        if (playerTurn == false)
        {
            yourturn.SetActive(false);
            enemyturn.SetActive(true);
        }
        if (playerTurn == true)
        {
            yourturn.SetActive(true);
            enemyturn.SetActive(false);
        }
        if (enemy.activeSelf == false)
        {
            playerTurn = true;
            yourturn.SetActive(true);
            enemyturn.SetActive(false);
        }
        if (player.activeSelf == false)
        {
            playerTurn = false;
            enemyturn.SetActive(true);
            yourturn.SetActive(false);
        }
        if (player.activeSelf == true)
        {

            if (Input.GetKeyDown(KeyCode.D) && playerTurn && !goal)
            {

                audioSource.PlayOneShot(sound1);
                moveX = -1;
                moveY = 0;
                playerTurn = false;
                UpdatePlayerPosition(moveX, moveY);



            }
            else if (Input.GetKeyDown(KeyCode.A) && playerTurn && !goal)
            {

                audioSource.PlayOneShot(sound1);
                moveX = 1;
                moveY = 0;
                playerTurn = false;
                UpdatePlayerPosition(moveX, moveY);

            }
            else if (Input.GetKeyDown(KeyCode.W) && playerTurn && !goal)
            {
                audioSource.PlayOneShot(sound1);
                moveX = 0;
                moveY = 1;
                playerTurn = false;
                UpdatePlayerPosition(moveX, moveY);

            }
            else if (Input.GetKeyDown(KeyCode.S) && playerTurn && !goal)
            {
                audioSource.PlayOneShot(sound1);
                moveX = 0;
                moveY = -1;
                playerTurn = false;
                UpdatePlayerPosition(moveX, moveY);

            }
            else
            {
                moveX = 0;
                moveY = 0;
                UpdatePlayerPosition(moveX, moveY);

            }
        }
        if (enemy.activeSelf == true)
        {


            if (!playerTurn && !goal)
            {
                Invoke("Enemyway", 1.0f);

                Debug.Log("?");
            }

            else
            {
                moveX = 0;
                moveY = 0;
                UpdateEnemyPosition(moveX, moveY);

            }
        }


        Debug.Log(playerTurn);


    }
    public void Enemyway()
    {

        enemynum = Random.Range(1, 3);
        Debug.Log(enemynum);
        if (enemynum == 1)
        {

            audioSource.PlayOneShot(sound1);
            moveX = 0;
            moveY = -1;
            playerTurn = true;
            UpdateEnemyPosition(moveX, moveY);
            CancelInvoke();
        }
        if (enemynum == 2)
        {

            audioSource.PlayOneShot(sound1);
            moveX = 1;
            moveY = 0;
            playerTurn = true;
            UpdateEnemyPosition(moveX, moveY);
            CancelInvoke();
        }
    }


    void UpdatePlayerPosition(int playerPositionX = 0, int playerPositionY = 0)
    {
        int[] position = new int[2];
        position = GetPosition(2);
        playerPositionX = position[0];
        playerPositionY = position[1];




        if (player.activeSelf == false)
        {
            playerPositionX = 100;
            playerPositionY = 100;
        }
        if (stageArray[playerPositionX + moveX, playerPositionY + moveY] == 1)
        {

            playerTurn = true;
            return;
        }



        else
        {
            if (stageArray[playerPositionX + moveX, playerPositionY + moveY] == 3)
            {
                audioSource.PlayOneShot(sound4);
                enemy.SetActive(false);
                playerTurn = true;


            }
            if (goalArray[playerPositionX + moveX, playerPositionY + moveY] == 2)
            {

                goalcanvas.SetActive(true);
                if (!goal)
                {
                    audioSource.PlayOneShot(sound3);
                    goal = true;
                    Debug.Log("うるさ");
                    PlayerPrefs.SetInt("SCORE", num + 50);
                    PlayerPrefs.Save();
                }

            }
            stageArray[playerPositionX, playerPositionY] = 0;
            stageArray[playerPositionX + moveX, playerPositionY + moveY] = 2;

            Hashtable moveHash = new Hashtable();

            moveHash.Add("position", new Vector3(playerPositionX, playerPositionY, transform.position.z));
            moveHash.Add("time", 0.4f);
            moveHash.Add("delay", 0.0f);
            iTween.MoveTo(player, moveHash);

        }

    }
    int[] GetPosition(int number)
    {
        int playerPositionX = 0;
        int playerPositionY = 0;
        for (int i = 0; i < stageArray.GetLength(0); i++)
        {
            for (int j = 0; j < stageArray.GetLength(1); j++)
            {
                if (stageArray[i, j] == number)
                {
                    playerPositionX = i;
                    playerPositionY = j;
                }

            }
        }
        int[] position = new int[2];
        position[0] = playerPositionX;
        position[1] = playerPositionY;
        return position;

    }


    void UpdateEnemyPosition(int enemyPositionX = 0, int enemyPositionY = 0)
    {

        int[] position = new int[2];
        position = GetPosition(3);
        enemyPositionX = position[0];
        enemyPositionY = position[1];

        if (enemy.activeSelf == false)
        {
            enemyPositionX = 100;
            enemyPositionY = 100;
        }


        if (stageArray[enemyPositionX + moveX, enemyPositionY + moveY] == 1)
        {

            //Enemyway();
            playerTurn = false;
            return;
        }

        else
        {
            if (stageArray[enemyPositionX + moveX, enemyPositionY + moveY] == 2)
            {
                audioSource.PlayOneShot(sound4);
                player.SetActive(false);
                playerTurn = false;

            }
            if (goalArray[enemyPositionX + moveX, enemyPositionY + moveY] == 1)
            {


                goalcanvas2.SetActive(true);

                if (!goal)
                {
                    audioSource.PlayOneShot(sound3);
                    goal = true;
                    Debug.Log("うるさ");
                }


            }
            stageArray[enemyPositionX, enemyPositionY] = 0;
            stageArray[enemyPositionX + moveX, enemyPositionY + moveY] = 3;

            Hashtable moveHash = new Hashtable();

            moveHash.Add("position", new Vector3(enemyPositionX, enemyPositionY, transform.position.z));
            moveHash.Add("time", 0.4f);
            moveHash.Add("delay", 0.0f);
            iTween.MoveTo(enemy, moveHash);

        }

    }

}






