using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class animationTime : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(videoLength());
    }

    // Update is called once per frame
    void Update () {
		
	}

    IEnumerator videoLength()
    {

        yield return new WaitForSeconds(48);
        SceneManager.LoadScene("MainMenu");
    }
}
