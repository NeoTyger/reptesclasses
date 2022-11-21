using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public WeaponStats objecte1;
    public WeaponStats objecte2;
    
    // Start is called before the first frame update
    void Start()
    {
        objecte1 = new WeaponStats("blasters", 0.25f, 50);
        objecte2 = new WeaponStats("rockets", 5f, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
