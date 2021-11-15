using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;


[System.Serializable]
public class SpaceTile : MonoBehaviour
{
    [SerializeField]
    bool canVisit = true, hasMiniGame = false, locked = false, goalTile = false, visited = false;

    private int tileID;

    [SerializeField] public string description;
    [SerializeField] public List<string> npcList;
    [SerializeField] public List<string> tileResources;
    [SerializeField] public float difficulty = 1.0f;
    [SerializeField] public int fuelCost = 1;

    //\\----------------------------------------------------\\//

    private void Start()
    {
        string tileNum = Regex.Replace(gameObject.name, "[a-z]", ""); // regex to the rescue! 
        tileID = System.Int32.Parse(tileNum);
    }

    public void spawnObject()
    {
        // creates an object related to the file
    }

/*    public T Get<T>()
    {
        return;
    }
*/
    public bool getCanVisitStatus()
    {
        return this.canVisit;
    }

    public bool getLockStatus()
    {
        return this.locked;
    }

    public void setLockedStatus(bool val)
    {
        this.locked = val;
    }

    public string getDescription()
    {
        return this.description;
    }

    public int getTileID()
    {
        return this.tileID;
    }

    public bool getVisited()
    {
        return this.visited;
    }

    public void setVisited(bool val)
    {
        this.visited = val;
    }


}
