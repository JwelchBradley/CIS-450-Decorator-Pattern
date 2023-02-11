/*
 * (Jacob Welch)
 * (PepperoniFoodTopping)
 * (Decorator)
 * (Description: Defines a pepperoni topping.)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PepperoniFoodTopping : FoodTopping
{
    #region Fields
    /// <summary>
    /// The cost of the food topping.
    /// </summary>
    public override float cost => base.cost + 2.0f;

    /// <summary>
    /// The ingredients that are in this food.
    /// </summary>
    public override string indgredients => base.indgredients + ", Pepporoni";
    #endregion

    #region Functions
    /// <summary>
    /// A constructor for a pepperoni topping.
    /// </summary>
    /// <param name="foodTopped"></param>
    public PepperoniFoodTopping(Food foodTopped)
    {
        foodToppedOn = foodTopped;
    }

    /// <summary>
    /// Adds the pepperoni sprite to the list of sprites for this food.
    /// </summary>
    /// <returns></returns>
    public override List<Sprite> AddFoodSprite()
    {
        var newSpritesList = foodToppedOn.sprites;
        newSpritesList.Add((Sprite)Resources.Load("Pepperoni", typeof(Sprite)));
        return newSpritesList;
    }
    #endregion
}
