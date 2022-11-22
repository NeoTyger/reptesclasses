using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDataBase : MonoBehaviour
{

    public Fruit fruit;

    public Coin coin;

    public Item[] llistaItems;

    private void Start()
    {
        //Debug.Log(llistaItems[0].itemName);
        //Debug.Log(llistaItems[0].GetItemName());

        //fruit = new Fruit("Sindri", "333", "Fruita de la famili Cucurbitaceae", 1f);
        //coin = new Coin("Euro", "111", "Moneda europea", 1);

        //Desde s'inspector s'ha de posar es tamany de sa llista a 3 o inizialitzar sa llista adalt a 3
        llistaItems[0] = new Fruit("Sindri", "333", "Fruita de la famili Cucurbitaceae", 100f);
        llistaItems[1] = new Fruit("Sindri", "333", "Fruita de la famili Cucurbitaceae", 100f);
        llistaItems[2] = new Coin("Euro", "111", "Moneda europea", 0);
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

        if (Input.GetKeyDown(KeyCode.I))
        {
            Informacio();
        }

    }

    private void Informacio()
    {
        foreach (var i in llistaItems)
        {
            i.MyTreat();
        }
        
        Debug.Log("Vida actual : " + fruit.health);
        Debug.Log("Punts actuals : " + coin.points);
    }

    private void BaixarVida()
    {
        fruit.health = fruit.health - 5;
        
    }

    private void IncrementarPuntuacio()
    {
        coin.points = coin.points + 1;
        
    }
}
