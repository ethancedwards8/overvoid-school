using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;

public class SpaceTile : MonoBehaviour
{
    [SerializeField]
    private bool canVisit = true, hasMiniGame = false, locked = false, goalTile = false, hasVisited = false;

    private int tileID;

    [SerializeField] private string description;
    //[SerializeField] public List<string> npcList;
    [SerializeField] public List<EPlanetResource> tileResources;
    [SerializeField] public float difficulty = 1.0f;
    [SerializeField] public int fuelCost = 1;

    private void Start()
    {
        string tileNum = Regex.Replace(gameObject.name, "[a-z]", ""); // regex to the rescue! 
        tileID = System.Int32.Parse(tileNum);
    }

    public void spawnObject()
    {
        // creates an object related to the file
    }

    // https://stackoverflow.com/questions/11159438/looking-for-a-short-simple-example-of-getters-setters-in-c-sharp
    // WOW, solves some issues.
    // allows us more flexibility in the future. More specifically in the setters area.
    public bool CanVisit
    {
        get { return canVisit; }
        set { speed = value; }
    }

    public bool HasMiniGame
    {
        get { return hasMiniGame; }
        set { hasMiniGame = value;}
    }

    public bool Locked
    {
        get { return locked; }
        set { locked = value; }
    }

    public bool GoalTile
    {
        get { return goalTile; }
        set { goalTile = value; }
    }

    public bool HasVisited
    {
        get { return hasVisited; }
        set { hasVisited = value; }
    }

    public string Description
    {
        get { return description; }
    }



    // public bool getCanVisitStatus()
    // {
    //     return this.canVisit;
    // }

    // public bool getLockStatus()
    // {
    //     return this.locked;
    // }

    // public void setLockedStatus(bool val)
    // {
    //     this.locked = val;
    // }

    // public string getDescription()
    // {
    //     return this.description;
    // }

    // public int getTileID()
    // {
    //     return this.tileID;
    // }

}
