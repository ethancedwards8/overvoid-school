using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct InventoryItem
{
    //public string name; // the name of item
    public EPlanetResource type; // the type of item
    public float value;

    public InventoryItem(/*string name,*/ EPlanetResource type, float value)
    {
        //this.name = name;
        this.type = type;
        this.value = value;
    }
}

// TODO: look into [UnityTest] and [Test]

public class InventoryController : MonoBehaviour
{
    [SerializeField] private int maxInvLength = 20; // max inv length

    [SerializeField] private List<InventoryItem> inventory = new List<InventoryItem>(); //Serializable so that we could manually add things

    private void Start()
    {

    }

    public bool addItem(InventoryItem item)
    {
        bool success = false;

        if (inventory.Count < maxInvLength) {
            inventory.Add(item);
            Debug.Log("added " + item);
            success = true;
        } else {
            Debug.Log("sorry, you're trying to add to a full array");
            success = false;
        }

        return success;
    }

    public bool removeItem(InventoryItem item)
    {
        bool success = false;

        if (inventory.Remove(item))
            success = true;
        else
            success = false;

        return success;
    }

    public InventoryItem checkInventory(int item)
    {
        return this.inventory[item];
    }

    public List<InventoryItem> listItems()
    {
        for (int i = 0; i < inventory.Count; i++)
            Debug.Log(this.inventory[i]);

        return this.inventory;
    }

    public bool containsItem(InventoryItem item)
    {
        bool found = false;

        if (inventory.Contains(item))
            found = true;
        else
            found = false;

        return found;
    }
}
