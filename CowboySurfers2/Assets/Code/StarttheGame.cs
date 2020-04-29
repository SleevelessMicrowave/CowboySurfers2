using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StarttheGame : MonoBehaviour {

public void PlayGame()
    {
        GM.coinTotal = 0;
        GM.timeTotal = 0;
        moveChar.zVel = 4;
        SceneManager.LoadScene("Loading");
    }
}
