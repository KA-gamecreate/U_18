using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1 : MonoBehaviour
{
    int _width;
    int _height;
    int _outOfRange = -1;
    int[] _values = null;
    public GameObject floorBlock;
    public GameObject wallBlock;
    public int Width
    {
        get { return _width; }
    }
    public int Height
    {
        get { return _height; }
    }
    public void Create(int width,int height)
    {
        _width = width;
        _height = height;
        _values = new int[Width * Height];
    }
    public int ToIdx(int x,int y)
    {
        return x +(y * Width);
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
    public int[,] stageArray = new int[6, 4]{
        {0,0,0,1},
        {0,0,0,0},
        {0,0,0,0},
        {0,0,0,0},
        {0,0,0,0},
        {1,0,0,0},
    };
    public int[,] PlayerArray = new int[6, 4]{
        {0,0,0,2},
        {0,0,0,0},
        {0,0,0,0},
        {0,0,0,0},
        {0,0,0,0},
        {2,0,0,0},
    };
    private void Start()
    {
        for (int i = 0; i < stageArray.GetLength(0); i++)
        {
            for (int j = 0; j < stageArray.GetLength(1); j++)
            {
                if (stageArray[i, j] == 0)
                {
                    Instantiate(floorBlock, new Vector3(i, -1, j), Quaternion.identity);
                }
                else
                {
                    Instantiate(wallBlock, new Vector3(i, 0, j), Quaternion.identity);

                }
            }
        }
    }
}