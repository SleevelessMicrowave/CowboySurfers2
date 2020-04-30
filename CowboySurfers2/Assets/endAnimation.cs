using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.Video;

public class endAnimation : MonoBehaviour
{
    public GameObject playButton;
    public VideoPlayer outro;

    // Use this for initialization
    void Start()
    {
        outro.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Game_Outro_VideoOnly.mp4");
        outro.Play();
        StartCoroutine(videoLength());
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayButtonClicked()
    {
        playButton.SetActive(true);
        
        SceneManager.LoadScene("LevelComplete");
    }

    IEnumerator videoLength()
    {

        yield return new WaitForSeconds(26);
        SceneManager.LoadScene("LevelComplete");
    }
}
