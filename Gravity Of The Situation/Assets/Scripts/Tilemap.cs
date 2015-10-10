using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class TileMap
    {
        public List<GameObject>[,] Tiles;

        public TileMap(int length, int height)
        {
            Tiles = new List<GameObject>[length, height];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Tiles[i, j] = null;
                }
            }
        }
    }
}
