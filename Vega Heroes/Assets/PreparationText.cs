using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PreparationText : MonoBehaviour
{

    Text prepText;
    // Use this for initialization
    void Start()
    {
                                                                        
    }

    // Update is called once per frame
    void Update()
    {
        prepText = GetComponent<Text>();
        UpdateDisplay();
    }
    public void UpdateDisplay()
    {
        prepText.text = ("Preparation time: " + FindObjectOfType<RecipesArrays>().GetActualPreparationTime().ToString());
    }
}
