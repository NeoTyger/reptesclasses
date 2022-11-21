using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.AI;

public class CustomerDB : MonoBehaviour
{

    public Customer[] customerList;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            ViewAllCustomers();
        }

        string tecla = Input.inputString;
        switch (tecla)
        {
            case "1":
                ViewOneCustomer(tecla);
                break;
            case "2":
                ViewOneCustomer(tecla);
                break;
            case "3":
                ViewOneCustomer(tecla);
                break;
            case "4":
                ViewOneCustomer(tecla);
                break;
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            WomenCustomer("Mujer");
        }


        if (Input.GetKeyDown(KeyCode.M))
        {
            IncreaseAge();   
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            CustomersWithA("A");
        }

    }

    public void ViewAllCustomers()
    {
        foreach (var c in customerList)
        {
            Debug.Log(c.ToString());
        }
    }

    public void ViewOneCustomer(string customer)
    {
        Debug.Log(customerList[int.Parse(customer)-1].ToString()); 
    }

    public void WomenCustomer(string gender)
    {
        foreach (var c in customerList)
        {
            if (c.gender == gender)
            {
                Debug.Log(c.firstName + " " + c.lastName);
            }
        }
    }

    public void IncreaseAge()
    {
        foreach (var c in customerList)
        {
            c.age = c.age + 3;
            Debug.Log(c.firstName + " " + c.lastName + " + 3 anys | Edat actualitzada : " + c.age);
        }
    }

    public void CustomersWithA(string word)
    {
        foreach (var c in customerList)
        {
            if (c.firstName.ToUpper().Contains(word) || c.lastName.ToUpper().Contains(word) )
            {
                Debug.Log(c.firstName + " " + c.lastName);
            }
        }
    }
}
