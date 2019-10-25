using UnityEngine;
using System.Collections;

public class Recipes
{
    public string name;
    public bool cheese;
    public bool garlic;
    public bool milk;
    public bool flour;
    public bool mushrooms;
    public bool peas;
    public bool egg;
    public bool pasta;
    public bool butter;
    public int preparationTime;
    public int serves;
    public string recipeText;

    public Recipes(string newName, bool newCheese, bool newGarlic, bool newMilk, bool newFlour, bool newMushrooms, bool newPeas, bool newEgg, bool newPasta, bool newButter, int newPreparationTime, int newServes, string newRecipeText)
    {
        name = newName;
        cheese = newCheese;
        garlic = newGarlic;
        milk = newMilk;
        flour = newFlour;
        mushrooms = newMushrooms;
        peas = newPeas;
        egg = newEgg;
        pasta = newPasta;
        butter = newButter;
        preparationTime = newPreparationTime;
        serves = newServes;
        recipeText = newRecipeText;





    }

}