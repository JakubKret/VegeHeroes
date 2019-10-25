using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class RecipesData {

    public bool firstTime;
    public int publicRandomFilteredIndex;
    public int currDay;
    public string recipe;

    public bool cheeseCaprice;
    public bool garlicCaprice;
    public bool milkCaprice;
    public bool flourCaprice;
    public bool mushroomsCaprice;
    public bool peasCaprice;
    public bool eggCaprice;
    public bool pastaCaprice;
    public bool butterCaprice;
    public int prepTimeCaprice;
    public int servesCaprice;

    public RecipesData(RecipesArrays recipes)
    {
        firstTime = recipes.firstTime;
        publicRandomFilteredIndex = recipes.publicRandomFilteredIndex;
        currDay = recipes.currDay;
        recipe = recipes.recipeText;
    }
    public RecipesData(Caprices caprice)
    {
        cheeseCaprice = caprice.cheeseCaprice;
        garlicCaprice = caprice.garlicCaprice;
        milkCaprice = caprice.milkCaprice;
        flourCaprice = caprice.flourCaprice;
        mushroomsCaprice = caprice.mushroomsCaprice;
        peasCaprice = caprice.peasCaprice;
        eggCaprice = caprice.eggCaprice;
        pastaCaprice = caprice.pastaCaprice;
        butterCaprice = caprice.butterCaprice;
        prepTimeCaprice = caprice.prepTimeCaprice;
        servesCaprice = caprice.servesCaprice;
    }
}
