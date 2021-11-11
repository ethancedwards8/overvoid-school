using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    [SerializeField] 
    private float xMax, xMin, yMax, yMin;
    [SerializeField] 
    private int mapWidth, mapHeight;

//\\----------------------------------------\\//

    public bool checkBounds(Transform playerPos, float xOffset, float yOffset)
    {
        float px = playerPos.position.x + xOffset;
        float py = playerPos.position.y + yOffset;
        bool inBounds = false;
        //checking players position against the min/max x/y values for current map and return true if we can move or false if not

        if((px <= xMax && px >= xMin) && (py <= yMax && py >= yMin))
        {
            inBounds = true;
        }
        else
        {
            inBounds = false;
        }
        return inBounds;
    }

    public int getMapHeight()
    {
        return this.mapHeight;
    }

    public int getMapWidth()
    {
        return this.mapWidth;
    }
}
