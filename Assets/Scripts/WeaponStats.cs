using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class WeaponStats
{

    [SerializeField] private string name;
    [SerializeField] private float fireRate;
    [SerializeField] private int ammoCount;


    public WeaponStats(string name, float fireRate, int ammoCount)
    {
            
        //Initialize things here
        this.name = name;
        this.fireRate = fireRate;
        this.ammoCount = ammoCount;
            
    }
        
}
    

