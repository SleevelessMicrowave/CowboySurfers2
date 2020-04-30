using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.Video;

public class animationTime : MonoBehaviour {

    public VideoPlayer intro;

	// Use this for initialization
	void Start () {
        intro.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Game_Intro_VideoOnly.mov");
        intro.Play();
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
