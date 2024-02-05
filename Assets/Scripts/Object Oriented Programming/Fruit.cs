/*****************************************************************************
// File Name : Fruit.cs
// Author : Andrew Maier
// Creation Date : January 24, 2024
//
// Brief Description : Defines variables of the list "FruitSalad" to complete
list parameters
*****************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit 
{
    public string name;
    public string color;
    public float weight;
    /// <summary>
    /// Defines the variables needed for Fruit
    /// </summary>
    /// <param name="name">Name of the fruit</param>
    /// <param name="c">Color of the fruit</param>
    /// <param name="w">weight of the fruit</param>
    public Fruit(string name, string c, float w)
    {
        this.name = name;
        color = c;
        weight = w;

    }
    /// <summary>
    /// Defines a new fruit if it is given no parameters
    /// </summary>
    public Fruit()
    {
        name = "mandarin";
        color = "orange";
        weight = 1.0f;
    }
    /// <summary>
    /// Defines new fruit if there is only a name parameter given
    /// </summary>
    /// <param name="name">name of fruit</param>
    public Fruit(string name)
    {
        this.name = name;
        color = "blue";
        weight = 2.7f;
    }
    /// <summary>
    /// Defines new fruit if there is only a weight parameter given
    /// </summary>
    /// <param name="w">weight of fruit</param>
    public Fruit(float w)
    {
        name = "watermelon";
        color = "red";
        weight = w;
    }
}
