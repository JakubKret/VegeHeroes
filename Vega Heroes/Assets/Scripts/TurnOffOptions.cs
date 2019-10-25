using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffOptions : MonoBehaviour {

    [SerializeField] GameObject Options;

    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void CancelOpt()
    {
        StartCoroutine(WaitForAnimationToEnd());
    }
    IEnumerator WaitForAnimationToEnd()
    {
        FindObjectOfType<TurnOffAnimation>().TurnOffAnim();
        yield return new WaitForSeconds(1);
        Options.SetActive(false);
        gameObject.SetActive(false);
    }
}
