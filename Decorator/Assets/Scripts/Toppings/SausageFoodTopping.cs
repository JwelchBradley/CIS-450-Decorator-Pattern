/*
 * (Jacob Welch)
 * (SausageFoodTopping)
 * (Decorator)
 * (Description: Defines a sausage topping. )
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SausageFoodTopping : FoodTopping
{
    #region Fields
    /// <summary>
    /// The cost of the food topping.
    /// </summary>
    public override float cost => base.cost + 3.0f;

    /// <summary>
    /// The ingredients that are in this food.
    /// </summary>
    public override string indgredients => base.indgredients + ", Sausage";
    #endregion

    #region Functions
    /// <summary>
    /// A constructor for a sausage topping.
    /// </summary>
    /// <param name="foodTopped"></param>
    public SausageFoodTopping(Food foodTopped)
    {
        foodToppedOn = foodTopped;
    }

    /// <summary>
    /// Adds the sausage sprite to the list of sprites for this food.
    /// </summary>
    /// <returns></returns>
    public override List<Sprite> AddFoodSprite()
    {
        var newSpritesList = foodToppedOn.sprites;
        newSpritesList.Add((Sprite)Resources.Load("Sausage", typeof(Sprite)));
        return newSpritesList;
    }
    #endregion
}
