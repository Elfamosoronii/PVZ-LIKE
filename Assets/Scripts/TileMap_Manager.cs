using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileMap_Manager : MonoBehaviour


{
    [SerializeField] private Tilemap tilemap = null;
    [SerializeField] private TilemapData[,] datas;
    public void Start()
    {
        datas = new TilemapData[tilemap.size.x, tilemap.size.y];
        for (int x = 0; x < tilemap.size.x; x++)
        { for (int y = 0; y < tilemap.size.y; y++)
            {
                datas[x, y].IsValid = true; 
            }   
                
        }
    }

   
}
