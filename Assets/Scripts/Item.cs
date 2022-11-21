using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Item
{
    [SerializeField] private string itemName;
    [SerializeField] private string id;
    [SerializeField] private string description;


    public Item(string itemName, string id, string description)
    {
            
        //Initialize things here
        this.itemName = itemName;
        this.id = id;
        this.description = description;
            
    }

    public object GetItemName()
    {
        return itemName;
    }
}
