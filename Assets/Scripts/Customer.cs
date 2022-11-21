using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Customer
{
    [SerializeField] public string firstName;
    [SerializeField] public string lastName;
    [SerializeField] public int age;
    [SerializeField] public string gender;
    [SerializeField] public string occupation;


    public Customer(string firstName, string lastName, int age, string gender, string occupation)
    {
            
        //Initialize things here
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.gender = gender;
        this.occupation = occupation;

    }

    public override string ToString()
    {
        return this.firstName + " " + this.lastName + " / " + this.age + " / " + this.gender + " / " + this.occupation;
    }
}
