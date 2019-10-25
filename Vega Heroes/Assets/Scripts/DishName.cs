using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DishName : MonoBehaviour {

    Text dishtext;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        dishtext = GetComponent<Text>();
        UpdateDisplay();
	}
    public void UpdateDisplay()
    {
        dishtext.text = FindObjectOfType<RecipesArrays>().GetActualNameOfDish();
        
    }
}
