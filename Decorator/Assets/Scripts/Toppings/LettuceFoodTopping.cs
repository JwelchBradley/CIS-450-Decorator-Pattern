/*
 * (Jacob Welch)
 * (LettuceFoodTopping)
 * (Decorator)
 * (Description: A class defining a lettuce topping.)
 */
using System.Collections.Generic;
using UnityEngine;

public class LettuceFoodTopping : FoodTopping
{
    #region Fields
    /// <summary>
    /// The cost of this food.
    /// </summary>
    public override float cost => base.cost + 1.0f;

    /// <summary>
    /// The ingredients that make up this food.
    /// </summary>
    public override string indgredients => base.indgredients + ", Lettuce";
    #endregion

    #region Functions
    /// <summary>
    /// A constructor for the lettuce topping.
    /// </summary>
    /// <param name="foodTopped"></param>
    public LettuceFoodTopping(Food foodTopped)
    {
        foodToppedOn = foodTopped;
    }

    /// <summary>
    /// Adds the lettuce sprite to the list of sprites for this food.
    /// </summary>
    /// <returns></returns>
    public override List<Sprite> AddFoodSprite()
    {
        var newSpritesList = foodToppedOn.sprites;
        newSpritesList.Add((Sprite)Resources.Load("Lettuce", typeof(Sprite)));
        return newSpritesList;
    }
    #endregion
}
