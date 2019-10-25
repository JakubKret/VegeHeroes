using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void LoadCapricesScene()
    {
        SceneManager.LoadScene("YourCaprices");
    }
    public void LoadMainSlide()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void LoadFridgeScene()
    {
        SceneManager.LoadScene("YourFridge");
    }
    public void LoadWhyShouldIUseThisApp()
    {
        SceneManager.LoadScene("WhyShouldIUseThisApp");
    }


}
