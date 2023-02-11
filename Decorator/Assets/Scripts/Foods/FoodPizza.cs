/*
 * (Jacob Welch)
 * (FoodPizza)
 * (Decorator)
 * (Description: A class defining a pizza food.)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodPizza : Food
{
    #region Fields
    /// <summary>
    /// The cost of the pizza.
    /// </summary>
    public override float cost => base.cost + 20.0f;

    /// <summary>
    /// The ingredients of the pizza.
    /// </summary>
    public override string indgredients => base.indgredients + "Dough, Tomato Sauce, Cheese";

    /// <summary>
    /// The sprites used to display the pizza.
    /// </summary>
    public override List<Sprite> sprites => new List<Sprite>() { (Sprite)Resources.Load("Pizza", typeof(Sprite)) };
    #endregion
}
