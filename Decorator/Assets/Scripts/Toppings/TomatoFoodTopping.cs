/*
 * (Jacob Welch)
 * (TomatoFoodTopping)
 * (Decorator)
 * (Description: A class defining a tomato topping.)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomatoFoodTopping : FoodTopping
{
    #region Fields
    /// <summary>
    /// The cost of the tomato topping.
    /// </summary>
    public override float cost => base.cost + 2.0f;

    /// <summary>
    /// The ingredients that are in this food.
    /// </summary>
    public override string indgredients => base.indgredients + ", Tomato";
    #endregion

    #region Functions
    /// <summary>
    /// A constructor for a tomato topping.
    /// </summary>
    /// <param name="foodTopped">The food that this tomato topping is on.</param>
    public TomatoFoodTopping(Food foodTopped)
    {
        foodToppedOn = foodTopped;
    }

    /// <summary>
    /// Adds the sprite for the tomator to the food list of sprites.
    /// </summary>
    /// <returns></returns>
    public override List<Sprite> AddFoodSprite()
    {
        var newSpritesList = foodToppedOn.sprites;
        newSpritesList.Add((Sprite)Resources.Load("Tomato", typeof(Sprite)));
        return newSpritesList;
    }
    #endregion
}
