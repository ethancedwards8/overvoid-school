using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Instantiate

public class BlockSpawning : MonoBehaviour
{
    public GameObject block;
    public int blockX;
    public int blockY;
    int totalBlocks = 0;
    int currentBlocks = 0;



    void Start()
    {
        totalBlocks = Random.Range(5, 50);
    }

    void Update()
    {
        coordsRandomizer();
        placeBlocks();
    }


    public void placeBlocks()
    {
        if (currentBlocks < totalBlocks)
        {
            Instantiate(block, new Vector2(blockX, blockY), Quaternion.identity);
            currentBlocks++;
        }
        else
        {

        }
    }
    
    public void coordsRandomizer()
    {
        blockX = Random.Range(-3, 3);
        blockY = Random.Range(-5, 5);
        Debug.Log("generated " + blockX + "," + blockY);
    }


}
