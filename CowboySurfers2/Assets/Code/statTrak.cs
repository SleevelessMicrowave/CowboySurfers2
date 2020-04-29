using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class statTrak : MonoBehaviour {

    public Text maxBottles;
    public Text maxTime;
    public Text bottles;
    public Text time;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        maxBottles.text = "Most Bottles Collected: " + GM.greatestBottle;
        maxTime.text = "Most Time Survived: " + GM.greatestTime;
        bottles.text = "Bottles Collected: " + GM.coinTotal;
        time.text = "Time Survived: " + GM.timeTotal;
    }
}
