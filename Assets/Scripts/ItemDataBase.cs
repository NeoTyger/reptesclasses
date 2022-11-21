using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDataBase : MonoBehaviour
{

    public Item[] llistaItems;

    private void Start()
    {
        //Debug.Log(llistaItems[0].itemName);
        Debug.Log(llistaItems[0].GetItemName());
    }
}
