using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    [SerializeField] private float xMax;
    [SerializeField] private float xMin;
    [SerializeField] private float yMax;
    [SerializeField] private float yMin;
    [SerializeField] private int mapWidth;
    [SerializeField] private int mapHeight;

//\\----------------------------------------\\//

    public bool checkBounds(Transform playerPos, float xoffset, float yoffset)
    {
        float px = playerPos.position.x + xoffset;
        float py = playerPos.position.y + yoffset;
        bool inbounds = false;
        //checking players position against the min/max x/y values for current map and return true if we can move or false if not

        if((px <= xMax && px >= xMin) && (py <= yMax && py >= yMin))
        {
            inbounds = true;
        }
        else
        {
            inbounds = false;
        }
        return inbounds;
    }

    public int getMapHeight()
    {
        return mapHeight;
    }

    public int getMapWidth()
    {
        return mapWidth;
    }

}
