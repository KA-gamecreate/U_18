﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1 : MonoBehaviour
{
    public bool playerTurn;
    //public bool enemyTurn;
    int _width;
    int _height;
    int _outOfRange = -1;
    int[] _values = null;
    
    int moveX;
    int moveY;
    public GameObject floorBlock;
    public GameObject wallBlock;
    public GameObject player;
    public GameObject enemy;
    public GameObject mygoal;
    public GameObject enemygoal;
    public GameObject goalcanvas;
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
        Debug.Log("[Array2D] (w,h)=(" + Width + "," + Height + ")");
        for (int y = 0; y < Height; y++)
        {
            string s = "";
            for (int x = 0; x < Width; x++)
            {
                s += Get(x, y) + ",";
            }
            Debug.Log(s);
        }
    }
    public int[,] stageArray = new int[6, 8]{
        {1,1,1,1,1,1,1,1},
        {1,0,0,0,0,0,3,1},
        {1,0,0,0,0,0,0,1},
        {1,0,0,0,0,0,0,1},
        {1,2,0,0,0,0,0,1},
        {1,1,1,1,1,1,1,1},
    };
    public int[,] goalArray = new int[6, 8]{
        {0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,2,0},
        {0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0},
        {0,1,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0},
    };

    private void Start()
    {
        playerTurn = true;

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
                else if(goalArray[i,j] == 2)
                {
                    Instantiate(enemygoal, new Vector3(i, j, 0), Quaternion.identity);

                }

            }
        }

        

    }
    void Update()
    {

        if (enemy.activeSelf == false)
        {
            playerTurn = true;
        }
        if (player.activeSelf == false)
        {
            playerTurn = false;

        }

        if (Input.GetKeyDown(KeyCode.D) && playerTurn)
            {
                moveX = -1;
                moveY = 0;
            playerTurn = false;
            UpdatePlayerPosition(moveX, moveY);
               
            }
            else if (Input.GetKeyDown(KeyCode.A) && playerTurn)
            {
                moveX = 1;
                moveY = 0;
            playerTurn = false;
            UpdatePlayerPosition(moveX, moveY);
                
            }
            else if (Input.GetKeyDown(KeyCode.W) && playerTurn)
            {
                moveX = 0;
                moveY = 1;
            playerTurn = false;
            UpdatePlayerPosition(moveX, moveY);
              
            }
            else if (Input.GetKeyDown(KeyCode.S) && playerTurn)
            {
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
        
    
            if (Input.GetKeyDown(KeyCode.RightArrow)&&!playerTurn)
            {
                moveX = -1;
                moveY = 0;
                playerTurn = true;
                UpdateEnemyPosition(moveX, moveY);
          
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) && !playerTurn)
            {
                moveX = 1;
                moveY = 0;
                playerTurn = true;
                UpdateEnemyPosition(moveX, moveY);
                
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow) && !playerTurn)
            {
                moveX = 0;
                moveY = 1;
            playerTurn = true;
            UpdateEnemyPosition(moveX, moveY);
               
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow) && !playerTurn)
            {
                moveX = 0;
                moveY = -1;
            playerTurn = true;
            UpdateEnemyPosition(moveX, moveY);
               
            }
            else
            {
                moveX = 0;
                moveY = 0;
                UpdateEnemyPosition(moveX, moveY);
               
        }
        Debug.Log(playerTurn);
        

    }
    void UpdatePlayerPosition(int playerPositionX = 0 , int playerPositionY = 0)
    {

        for (int i = 0; i < stageArray.GetLength(0); i++)
        {
            for (int j = 0; j < stageArray.GetLength(1); j++)
            {
                if (stageArray[i, j] == 2)
                {
                    playerPositionX = i;
                    playerPositionY = j;
                }

            }
        }
        Debug.Log("A");
        if (stageArray[playerPositionX + moveX, playerPositionY + moveY] == 1)
        {
            Debug.Log("壁");
            playerTurn = true;
            return;
        }
        
        
        else
        {
            if (stageArray[playerPositionX + moveX, playerPositionY + moveY] == 3)
            {
                enemy.SetActive(false);
                playerTurn = true;
                Debug.Log("testdayon");

            }
            if (goalArray[playerPositionX + moveX, playerPositionY + moveY] == 2)
            {
                goalcanvas.SetActive(true);
                Debug.Log("testdayo");
            }
            stageArray[playerPositionX, playerPositionY] = 0;
            stageArray[playerPositionX + moveX, playerPositionY + moveY] = 2;

            Hashtable moveHash = new Hashtable();
            Debug.Log(playerPositionX);
            moveHash.Add("position", new Vector3(playerPositionX, playerPositionY, transform.position.z));
            moveHash.Add("time", 0.4f);
            moveHash.Add("delay", 0.0f);
            iTween.MoveTo(player, moveHash);

        }
        
    }
    void UpdateEnemyPosition(int enemyPositionX = 0, int enemyPositionY = 0)
    {

        for (int i = 0; i < stageArray.GetLength(0); i++)
        {
            for (int j = 0; j < stageArray.GetLength(1); j++)
            {
                if (stageArray[i, j] == 3)
                {
                   enemyPositionX = i;
                   enemyPositionY = j;
                }

            }
        }
        
        Debug.Log(enemyPositionX + "enemyPositionX");
        Debug.Log(enemyPositionY + "enemyPositionY");
        if (stageArray[enemyPositionX + moveX, enemyPositionY + moveY] == 1)
        {


            Debug.Log("壁");
            playerTurn = false;
            return;
        }
        
        else
        {
           if (stageArray[enemyPositionX + moveX, enemyPositionY + moveY] == 2)
            {
                player.SetActive(false);
                playerTurn = false;
                Debug.Log("testt");
            }
            if (goalArray[enemyPositionX + moveX, enemyPositionY + moveY] == 1)
            {
                goalcanvas.SetActive(true);
                Debug.Log("test");
            }
            stageArray[enemyPositionX, enemyPositionY] = 0;
            stageArray[enemyPositionX + moveX, enemyPositionY + moveY] = 3;

            Hashtable moveHash = new Hashtable();
            Debug.Log(enemyPositionX + "aaa");
            moveHash.Add("position", new Vector3(enemyPositionX, enemyPositionY, transform.position.z));
            moveHash.Add("time", 0.4f);
            moveHash.Add("delay", 0.0f);
            iTween.MoveTo(enemy, moveHash);

        }
        
    }
}
    


