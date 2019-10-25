using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsTurningOn : MonoBehaviour {

    [SerializeField] GameObject Options;
    [SerializeField] GameObject OptionsCancelDetector;

    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void TurnOnOptions()
    {
        Options.SetActive(true);
    }
    public void CancelOptions()
    {
        OptionsCancelDetector.SetActive(true);
    }
}
