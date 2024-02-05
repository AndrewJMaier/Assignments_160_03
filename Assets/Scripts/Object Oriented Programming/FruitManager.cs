/*****************************************************************************
// File Name : FruitManager.cs
// Author : Andrew Maier
// Creation Date : January 24, 2024
//
// Brief Description : Creates and adds to the Fruit Salad list
*****************************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitManager : MonoBehaviour
{
    public List<Fruit> FruitSalad;

    /// <summary>
    /// Start is called before the first frame update
    /// creates FruitSalad list
    /// </summary>
    void Start()
    {
        FruitSalad = new List<Fruit>();     //defining list of fruits

        Fruit fruit = new Fruit("apple", "green", 1.2f);

        FruitSalad.Add(fruit);

        CreateFruitSalad();
        DisplayFruitSalad();
    }

    /// <summary>
    /// Adds fruit to the list FruitSalad
    /// </summary>
    private void CreateFruitSalad()
    {
        FruitSalad.Add(new Fruit());

        FruitSalad.Add(new Fruit("strawberry"));

        FruitSalad.Add(new Fruit(2.7f));
       
    }
    /// <summary>
    /// Prints the values of the items inside of FruitSalad
    /// </summary>
    private void DisplayFruitSalad()
    {
        
        for(int i = 0; i < FruitSalad.Count; i++)
        {
            print(FruitSalad[i].color + " " + FruitSalad[i].name + " weighing " + FruitSalad[i].weight + " units");
        }
    }
}
