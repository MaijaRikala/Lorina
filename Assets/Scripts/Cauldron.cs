using UnityEngine;
using System.Collections.Generic;



public class Cauldron : MonoBehaviour
{
    // Class variables

    public static Cauldron Instance { get; private set; }

    // List for ingredients
    private List<string> Ingredients = new List<string>();
    // Values describing the potion
    // TODO: check that variable names make sense
    private int Temperature;
    private int Consistency;



    // Initialize variables
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(Instance);
        }
        Instance = this;
        // Set temperature and consistency
        Temperature = 0;
        Consistency = 0;
    }


    // Handle destroying Cauldron
    void OnDestroy()
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // Called, when player adds an ingredient
    void addIngredient(Ingredient ingredient)
    {
        Ingredients.Add(ingredient.ingredientName); // Add only name of the ingredient to list
        changeTemperature(ingredient.temperature);
        changeConsistency(ingredient.consistency);
    }

    // Called, when player changes temperature of the potion
    void changeTemperature(int temperature)
    {
        this.Temperature = Temperature + temperature;
    }

    // Called, when player stirs the potion
    void changeConsistency(int consistency)
    {
        this.Consistency = Consistency + consistency;
    }
}
