/*
 * (Jacob Welch)
 * (FoodBurger)
 * (Decorator)
 * (Description: A class defining a burger food. )
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodBurger : Food
{
    #region Fields
    /// <summary>
    /// The cost of the burger.
    /// </summary>
    public override float cost => base.cost + 10.0f;

    /// <summary>
    /// The ingredients of the burger.
    /// </summary>
    public override string indgredients => base.indgredients + "Buns, Burger";

    /// <summary>
    /// The sprites used to dipslay the burger.
    /// </summary>
    public override List<Sprite> sprites => new List<Sprite>() { (Sprite)Resources.Load("Burger", typeof(Sprite)) };
    #endregion
}
