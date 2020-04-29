using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class delayappear : MonoBehaviour {

    public GameObject button;
    public GameObject wait;
   
    IEnumerator ShowAndHide(GameObject go, float delay)
{
    go.SetActive(false);
    yield return new WaitForSeconds(delay);
    go.SetActive(true);
}
	// Use this for initialization
	void Start () {
        StartCoroutine(ShowAndHide(button, 5.0f));
        StartCoroutine(ShowAndHide(wait, 5.0f));
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

