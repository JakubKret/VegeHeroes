using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ServesText : MonoBehaviour
{

    Text serveText;
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        serveText = GetComponent<Text>();
        UpdateDisplay();
    }
    public void UpdateDisplay()
    {
        serveText.text = ("Serves: " + FindObjectOfType<RecipesArrays>().GetActualServes().ToString());
    }
}