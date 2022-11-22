using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Customer
{
    public string firstName;
    public string lastName;
    public int age;
    public string gender;
    public string occupation;


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
