using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Instantiate

public class BlockSpawning : MonoBehaviour
{
    public GameObject[] block;
    //public 

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

    }
    
    public void coordsRandomizer()
    {
        blockX = Random.Range(-3, 3);
        blockX = Random.Range(-50, 5);
        Debug.Log("generated " + blockX + "," + blockY);
    }


}
