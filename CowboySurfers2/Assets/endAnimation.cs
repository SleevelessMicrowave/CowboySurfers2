using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class endAnimation : MonoBehaviour
{
    public GameObject playButton;

    // Use this for initialization
    void Start()
    {
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
