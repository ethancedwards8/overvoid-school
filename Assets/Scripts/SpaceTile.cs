using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceTile : MonoBehaviour
{

    [SerializeField] bool canVisit = false;
    [SerializeField] bool hasMiniGame = false;
    [SerializeField] bool locked = false;
    [SerializeField] bool goalTile = false;
    [SerializeField] bool visited = false;

    [SerializeField] private int tileID;

    [SerializeField] public string description;
    [SerializeField] public List<string> npcList;
    [SerializeField] public List<string> tileResources;
    [SerializeField] public float difficulty = 1.0f;
    [SerializeField] public int fuelCost = 1;

//\\----------------------------------------------------\\//

    public void spawnObject()
    {

    }

    public bool getCanVisitStatus()
    {
        return canVisit;
    }

    public bool getLockStatus()
    {
        return locked;
    }

    public void setLockedStatus(bool val)
    {
        locked = val;
    }

    public string getDescription()
    {
        return description;
    }

    public int getTileID()
    {
        return tileID;
    }

}
