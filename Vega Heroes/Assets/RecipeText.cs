using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecipeText : MonoBehaviour
{

    Text recipeText;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        recipeText = GetComponent<Text>();
        UpdateDisplay();
    }
    public void UpdateDisplay()
    {
        recipeText.text = SaveSystem.LoadRecipes().recipe;
    }
}