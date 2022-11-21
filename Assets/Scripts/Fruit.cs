using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : Item
{

    public float health;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Fruit(string itemName, string id, string description) : base(itemName, id, description)
    {
    }
}
