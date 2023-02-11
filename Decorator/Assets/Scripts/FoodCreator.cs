/*
 * (Jacob Welch)
 * (FoodCreator)
 * (Decorator)
 * (Description: Handles the creation of food and their toppings.)
 */
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FoodCreator : MonoBehaviour
{
    #region Fields
    /// <summary>
    /// The current food being displayed.
    /// </summary>
    private Food currentFood;

    /// <summary>
    /// Handles the ssetting of the current food which calls for it to be displayed.
    /// </summary>
    public Food CurrentFood
    {
        get => currentFood;
        set
        {
            currentFood = value;
            PrintFood();
        }
    }

    [Tooltip("The text for showing the type of food being orderd")]
    [SerializeField] private TextMeshProUGUI foodText;
    
    [Tooltip("The text for showing the ingredients in the food being ordered")]
    [SerializeField] private TextMeshProUGUI ingredientsText;

    [Tooltip("The text for showing the cost of the food being ordered")]
    [SerializeField] private TextMeshProUGUI costText;

    /// <summary>
    /// The objects displayed each food and topping on the screen.
    /// </summary>
    private List<GameObject> foodDisplays = new List<GameObject>();
    #endregion

    #region Functions
    #region Inputs
    /// <summary>
    /// Gets user inputs each frame.
    /// </summary>
    private void Update()
    {
        CreateFoodInput();
        ToppingInput();
    }

    /// <summary>
    /// Gets inputs for creating foods.
    /// </summary>
    private void CreateFoodInput()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            CreateBurger();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            CreatePizza();
        }
    }

    /// <summary>
    /// Gets inputs for adding and removing toppings to foods.
    /// </summary>
    private void ToppingInput()
    {
        if (CurrentFood == null) return;

        // Pizza Toppings
        if (CurrentFood.indgredients.Contains("Dough"))
        {
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                CurrentFood = new PepperoniFoodTopping(CurrentFood);
            }

            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                CurrentFood = new SausageFoodTopping(CurrentFood);
            }
        }

        // Burger toppings
        if (CurrentFood.indgredients.Contains("Burger"))
        {
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                CurrentFood = new LettuceFoodTopping(CurrentFood);
            }

            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                CurrentFood = new TomatoFoodTopping(CurrentFood);
            }
        }

        // Removes toppings
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            if (CurrentFood is FoodTopping)
            {
                CurrentFood = ((FoodTopping)CurrentFood).foodToppedOn;
            }
        }
    }
    #endregion

    /// <summary>
    /// Creates a new burger to be the current food.
    /// </summary>
    private void CreateBurger()
    {
        CurrentFood = new FoodBurger();
        foodText.text = "Food: Burger";
    }

    /// <summary>
    /// Creates a new pizza to be the current food.
    /// </summary>
    private void CreatePizza()
    {
        CurrentFood = new FoodPizza();
        foodText.text = "Food: Pizza";
    }

    /// <summary>
    /// Displays the food onto the screen with all of its fields.
    /// </summary>
    private void PrintFood()
    {
        costText.text = "Cost: $" + CurrentFood.cost;
        ingredientsText.text = "Ingredients: " + CurrentFood.indgredients;

        foreach(GameObject obj in foodDisplays)
        {
            Destroy(obj);
        }

        var posMod = 0;

        foreach(Sprite sprite in CurrentFood.sprites)
        {
            var spriteObj = new GameObject(sprite.name);
            spriteObj.transform.position = transform.position + new Vector3(0, posMod, 0);
            foodDisplays.Add(spriteObj);

            var sr = spriteObj.AddComponent<SpriteRenderer>();
            sr.sprite = sprite;
            sr.sortingOrder = posMod++;
        }
    }
    #endregion
}
