using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatMap : MonoBehaviour
{
    [SerializeField] private GameObject outSideCor;
    [SerializeField] private GameObject outSideWall;
    [SerializeField] private GameObject insideCor;
    [SerializeField] private GameObject insideWall;
    [SerializeField] private GameObject normalPellet;
    [SerializeField] private GameObject superPellet;
    [SerializeField] private GameObject TWall;
    private int[,] levelMap =
    {
        {1,2,2,2,2,2,2,2,2,2,2,2,2,7},
        {2,5,5,5,5,5,5,5,5,5,5,5,5,4},
        {2,5,3,4,4,3,5,3,4,4,4,3,5,4},
        {2,6,4,0,0,4,5,4,0,0,0,4,5,4},
        {2,5,3,4,4,3,5,3,4,4,4,3,5,3},
        {2,5,5,5,5,5,5,5,5,5,5,5,5,5},
        {2,5,3,4,4,3,5,3,3,5,3,4,4,4},
        {2,5,3,4,4,3,5,4,4,5,3,4,4,3},
        {2,5,5,5,5,5,5,4,4,5,5,5,5,4},
        {1,2,2,2,2,1,5,4,3,4,4,3,0,4},
        {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
        {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
        {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
        {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
        {0,0,0,0,0,0,5,0,0,0,4,0,0,0},
    };



    public int Length = 15;
    public int Width = 14;
    private float offset;

    private void Awake()
    {
        offset = 128 / outSideCor.GetComponent<SpriteRenderer>().sprite.pixelsPerUnit;
    }
    private void Start()
    {
        InitialMap();
    }
    private void InitialMap()
    {
        //TopLeft
        for (int i = 0; i < Length; ++i)
        {
            for (int j = 0; j < Width; ++j)
            {
                GameObject go = null;
                Vector3 position = new Vector3(j - 10.69f, -i + 14.52f);
                switch (levelMap[i, j])
                {
                    case 0:
                        break;
                    case 1:
                        go = Instantiate(outSideCor, position, Quaternion.identity);
                        break;
                    case 2:
                        go = Instantiate(outSideWall, position, Quaternion.identity);
                        break;
                    case 3:
                        go = Instantiate(insideWall, position, Quaternion.identity);
                        break;
                    case 4:
                        go = Instantiate(insideWall, position, Quaternion.identity);
                        break;
                    case 5:
                        go = Instantiate(normalPellet, position, Quaternion.identity);
                        break;
                    case 6:
                        go = Instantiate(superPellet, position, Quaternion.identity);
                        break;
                    case 7:
                        go = Instantiate(TWall, position, Quaternion.identity);
                        break;
                }
            }
        }
        //BottomLeft
        for (int i = 0; i < Length; ++i)
        {
            for (int j = 0; j < Width; ++j)
            {
                GameObject go = null;
                Vector3 position = new Vector3(j - 10.69f, i - 14.48f);
                switch (levelMap[i, j])
                {
                    case 0:
                        break;
                    case 1:
                        go = Instantiate(outSideCor, position, Quaternion.identity);
                        break;
                    case 2:
                        go = Instantiate(outSideWall, position, Quaternion.identity);
                        break;
                    case 3:
                        go = Instantiate(insideWall, position, Quaternion.identity);
                        break;
                    case 4:
                        go = Instantiate(insideWall, position, Quaternion.identity);
                        break;
                    case 5:
                        go = Instantiate(normalPellet, position, Quaternion.identity);
                        break;
                    case 6:
                        go = Instantiate(superPellet, position, Quaternion.identity);
                        break;
                    case 7:
                        go = Instantiate(TWall, position, Quaternion.identity);
                        break;
                }
            }
        }
        //BottomRight
        for (int i = 0; i < Length; ++i)
        {
            for (int j = 0; j < Width; ++j)
            {
                GameObject go = null;
                Vector3 position = new Vector3(-j + 16.33f, i - 14.42f);
                switch (levelMap[i, j])
                {
                    case 0:
                        break;
                    case 1:
                        go = Instantiate(outSideCor, position, Quaternion.identity);
                        break;
                    case 2:
                        go = Instantiate(outSideWall, position, Quaternion.identity);
                        break;
                    case 3:
                        go = Instantiate(insideWall, position, Quaternion.identity);
                        break;
                    case 4:
                        go = Instantiate(insideWall, position, Quaternion.identity);
                        break;
                    case 5:
                        go = Instantiate(normalPellet, position, Quaternion.identity);
                        break;
                    case 6:
                        go = Instantiate(superPellet, position, Quaternion.identity);
                        break;
                    case 7:
                        go = Instantiate(TWall, position, Quaternion.identity);
                        break;
                }
            }
        }
        //TopRight
        for (int i = 0; i < Length; ++i)
        {
            for (int j = 0; j < Width; ++j)
            {
                GameObject go = null;
                Vector3 position = new Vector3(-j + 16.2f, -i + 14.55f);
                switch (levelMap[i, j])
                {
                    case 0:
                        break;
                    case 1:
                        go = Instantiate(outSideCor, position, Quaternion.identity);
                        break;
                    case 2:
                        go = Instantiate(outSideWall, position, Quaternion.identity);
                        break;
                    case 3:
                        go = Instantiate(insideWall, position, Quaternion.identity);
                        break;
                    case 4:
                        go = Instantiate(insideWall, position, Quaternion.identity);
                        break;
                    case 5:
                        go = Instantiate(normalPellet, position, Quaternion.identity);
                        break;
                    case 6:
                        go = Instantiate(superPellet, position, Quaternion.identity);
                        break;
                    case 7:
                        go = Instantiate(TWall, position, Quaternion.identity);
                        break;
                }
            }
        }
    }
}
