using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Coin : Item
{

    public int points;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Coin(string itemName, string id, string description, int points) : base(itemName, id, description)
    {
        this.points = points;
    }
}
