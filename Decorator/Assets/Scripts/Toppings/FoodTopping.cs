/*
 * (Jacob Welch)
 * (FoodTopping)
 * (Decorator)
 * (Description: A base class for all food toppings. )
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FoodTopping : Food
{
    #region Fields
    /// <summary>
    /// The cost of the food topping.
    /// </summary>
    public override float cost => foodToppedOn.cost;

    /// <summary>
    /// The ingredients in the food.
    /// </summary>
    public override string indgredients => foodToppedOn.indgredients;

    /// <summary>
    /// The sprites used to display the food.
    /// </summary>
    public override List<Sprite> sprites => AddFoodSprite();

    /// <summary>
    /// The food that this topping is on.
    /// </summary>
    public Food foodToppedOn { get; protected set; }

    /// <summary>
    /// An abstract funtion for adding topping sprites onto all of the other sprites.
    /// </summary>
    /// <returns></returns>
    public abstract List<Sprite> AddFoodSprite();
    #endregion
}
