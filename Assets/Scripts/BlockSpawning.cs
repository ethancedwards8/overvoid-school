using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Instantiate

public class BlockSpawning : MonoBehaviour
{
    public GameObject block;
    public int blockX;
    public int blockY;


    void Start()
    {
        coordsRandomizer();
    }

    void Update()
    {

    }


    public void placeBlocks()
    {
        int totalBlocks = 0;
        int currentBlocks = 0;
        if (currentBlocks < totalBlocks)
        {
            Instantiate(block, new Vector2(blockX, blockY), Quaternion.identity);
            currentBlocks++;
        }
        else
        {

    }
    
    public void coordsRandomizer()
    {
        blockX = Random.Range(-3, 3);
        blockX = Random.Range(-50, 5);
        Debug.Log("generated " + blockX + "," + blockY);
    }


}
