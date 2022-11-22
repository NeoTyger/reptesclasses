using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

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

    public Fruit(string itemName, string id, string description, float health) : base(itemName, id, description)
    {
        this.health = health;
    }

    public override void MyTreat()
    {
        Debug.Log("Soc una fruita!");
    }
}
