using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class stats : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void RestartButton()
    {
        SceneManager.LoadScene("Main");

    }

    // Update is called once per frame
    void Update() {
        if (gameObject.name == "CoinTotal") { 
        GetComponent<TextMesh>().text = "Bottles Collected: " + GM.coinTotal;
    }
        if (gameObject.name == "time")
        {
            GetComponent<TextMesh>().text = "Time Elapsed: " + (Mathf.Round(GM.timeTotal*10))/10;
        }
	}
}
