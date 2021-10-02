using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGrid : MonoBehaviour
{
    List<Tile> tiles;
    public int gridSize;

    // 1. Have a sorted tileGrid
    // 2. Check each neighboring Tile to get the possible connections (Wood connects to wood on two levels, ground and urban only have ground level)
    // 3. 

    void GetConnections()
    {
        for(int x = 0; x < gridSize; x++)
        {
            for(int y = 0; y < gridSize; y++)
            {
                int c = x + y * gridSize;
                int x1 = c - 1;
                int x2 = c + 1;
                int y1 = c - gridSize;
                int y2 = c + gridSize;

                Tile C = tiles[c];
            }
        }
    }
}
