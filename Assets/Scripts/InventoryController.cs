using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItem
{
    public string name; // the name of item
    public EPlanetResource type; // the type of item
}

public class InventoryController : MonoBehaviour
{
    private int arrayPtr = 0;

    // Example code for both implementations:

    // If its weight: We use a list - as you can expand a list
    // List<InventoryItem> listInv = new List<InventoryItem>();
    // OBSOLETE 

    // If its slot based: We use an array - as you cannot expand an array, making it an obvious choice for a slot based inventory
    public InventoryItem[] slotInv = new InventoryItem[5];

    // so, we have changed our datatypes from string -> to InventoryItem, which will represent our items in our inventory

    public void addItem(InventoryItem item)
    {
        if (arrayPtr <= slotInv.Length) {
            slotInv[arrayPtr] = item;
            arrayPtr++;
        } else {
            Debug.Log("sorry, you're trying to access an element that doesn't exist");
        }
    }

    public void removeItem(int slot)
    {
        slotInv[slot] = null;
        arrayPtr--;
    }


}
