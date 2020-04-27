using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class stats : MonoBehaviour {

    public int greatestBottle = 0;
    public float greatestTime = 0;

	// Use this for initialization
	void Start () {
		
	}

    public void RestartButton()
    {
        GM.lvlCompStatus = "";
        GM.coinTotal = 0;
        GM.timeTotal = 0;
        GM.zVelAdj = 1;
        SceneManager.LoadScene("Main");

    }

    public void RestartPlay()
    {
        
        SceneManager.LoadScene("MainMenu");
    }

    // Update is called once per frame
    void Update() {
        if (GM.coinTotal > greatestBottle)
        {
            greatestBottle = GM.coinTotal;
        }
        if ((Mathf.Round(GM.timeTotal*10))/10 > greatestTime)
        {
            greatestTime = (Mathf.Round(GM.timeTotal * 10)) / 10;
        }

        if (gameObject.name == "CoinTotal") { 
        GetComponent<TextMesh>().text = "Bottles Collected: " + GM.coinTotal;
    }
        if (gameObject.name == "time")
        {
            GetComponent<TextMesh>().text = "Time Elapsed: " + (Mathf.Round(GM.timeTotal*10))/10;
        }
        if (gameObject.name == "BottleUI")
        {
            GetComponent<Text>().text = "Bottles Collected: " + GM.coinTotal;
        }
        if (gameObject.name == "timeUI")
        {
            GetComponent<Text>().text = "Time Elapsed: " + (Mathf.Round(GM.timeTotal * 10)) / 10;
        }
        if (gameObject.name == "HighScoreBottle")
        {
            GetComponent<Text>().text = "Most Bottles Collected: " + greatestBottle;
        }
        if (gameObject.name == "LongestTime")
        {
            GetComponent<Text>().text = "Longest Time: " + greatestTime;
        }
    }
}
