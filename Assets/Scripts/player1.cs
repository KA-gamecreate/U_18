using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1 : MonoBehaviour
{
    int _width;
    int _height;
    int _outOfRange = -1;
    int[] _values = null;
    
    int moveX;
    int moveY;
    public GameObject floorBlock;
    public GameObject wallBlock;
    public GameObject player;
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
    public int[,] stageArray = new int[8, 6]{
        {1,1,1,1,1,1},
        {1,0,0,0,0,1},
        {1,0,0,0,0,1},
        {1,0,0,0,0,1},
        {1,0,0,0,0,1},
        {1,0,0,0,0,1},
        {1,0,0,0,0,1},
        {1,1,1,1,1,1},
    };
    public int[,] playerArray = new int[8, 6]{
        {0,0,0,0,0,0},
        {0,0,0,0,2,0},
        {0,0,0,0,0,0},
        {0,0,0,0,0,0},
        {0,0,0,0,0,0},
        {0,0,0,0,0,0},
        {0,2,0,0,0,0},
        {0,0,0,0,0,0},
    };

    private void Start()
    {
        for (int i = 0; i < stageArray.GetLength(0); i++)
        {
            for (int j = 0; j < stageArray.GetLength(1); j++)
            {
                if (stageArray[i, j] == 0)
                {
                    Instantiate(floorBlock, new Vector3(i, j, -1), Quaternion.identity);
                }
                else
                {
                    Instantiate(wallBlock, new Vector3(i, j, -1), Quaternion.identity);

                }

            }
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            moveX = -1;
            moveY = 0;
            UpdatePlayerPosition(moveX, moveY);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            moveX = 1;
            moveY = 0;
            UpdatePlayerPosition(moveX, moveY);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            moveX = 0;
            moveY = 1;
            UpdatePlayerPosition(moveX, moveY);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            moveX = 0;
            moveY = -1;
            UpdatePlayerPosition(moveX, moveY);
        }
        else
        {
            moveX = 0;
            moveY = 0;
            UpdatePlayerPosition(moveX, moveY);
        }
    }
    void UpdatePlayerPosition(int playerPositionX = 0 , int playerPositionY = 0)
    {

        for (int i = 0; i < playerArray.GetLength(0); i++)
        {
            for (int j = 0; j < playerArray.GetLength(1); j++)
            {
                if (playerArray[i, j] == 2)
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
            return;
        }
        else
        {
            playerArray[playerPositionX, playerPositionY] = 0;
            playerArray[playerPositionX + moveX, playerPositionY + moveY] = 2;

            Hashtable moveHash = new Hashtable();
            Debug.Log(playerPositionX);
            moveHash.Add("position", new Vector3(playerPositionX, playerPositionY, transform.position.z));
            moveHash.Add("time", 0.4f);
            moveHash.Add("delay", 0.0f);
            iTween.MoveTo(player, moveHash);

        }
    }
}
    


