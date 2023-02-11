/*
 * (Jacob Welch)
 * (Food)
 * (Decorator)
 * (Description: A base class for all food.)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Food
{
    /// <summary>
    /// The sprites that this food has for its visuals.
    /// </summary>
    public virtual List<Sprite> sprites { get; private set; } = new List<Sprite>();

    /// <summary>
    /// The ingredients that make up this food.
    /// </summary>
    public virtual string indgredients { get; private set; } = "";

    /// <summary>
    /// The cost of thsi food.
    /// </summary>
    public virtual float cost { get; private set; } = 0;
}
