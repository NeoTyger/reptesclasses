using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDataBase : MonoBehaviour
{

    public Fruit fruit;

    public Coin coin;

    //public Item[] llistaItems;

    private void Start()
    {
        //Debug.Log(llistaItems[0].itemName);
        //Debug.Log(llistaItems[0].GetItemName());

        fruit = new Fruit("Sindri", "333", "Fruita de la famili Cucurbitaceae", 1f);
        coin = new Coin("Euro", "111", "Moneda europea", 1);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            IncrementarPuntuacio();
        }
        
        if (Input.GetKeyDown(KeyCode.F))
        {
            BaixarVida();
        }

    }

    private void BaixarVida()
    {
        fruit.health = fruit.health - 5;
        Debug.Log("Vida actual : " + fruit.health);
    }

    private void IncrementarPuntuacio()
    {
        coin.points = coin.points + 1;
        Debug.Log("Punts actuals : " + coin.points);
    }
}
