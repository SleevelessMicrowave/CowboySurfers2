using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class playAnimation : MonoBehaviour {

	// Use this for initialization
	void Start () {

        StartCoroutine(videoLength());

        Debug.Log("Works");
        SceneManager.LoadScene("Main");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator videoLength()
    {
        Debug.Log("Works2");
        yield return new WaitForSeconds(5);
        
    }
}
