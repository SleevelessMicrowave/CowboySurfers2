using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class playAnimation : MonoBehaviour {

    public GameObject skipButton;
    public GameObject playButton;

	// Use this for initialization
	void Start () {

        StartCoroutine(videoLength());

        
        
    }

    public void SkipButtonClicked()
    {
        skipButton.SetActive(true);
        SceneManager.LoadScene("MainMenu");
    }

    public void PlayButtonClicked()
    {
        playButton.SetActive(true);
        
        SceneManager.LoadScene("Main");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator videoLength()
    {
        
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Main");
    }
}
