using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cooldown : MonoBehaviour {
    public Image imageCoolDown;
    private float cooldown = 30;
    bool isCooldown;
    
	
	
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(GM.dynamite))
        {
            isCooldown = true;
        }

        if (isCooldown)
        {
            imageCoolDown.fillAmount += (1 / cooldown) * Time.deltaTime;

            if (imageCoolDown.fillAmount == 1)
            {
                imageCoolDown.fillAmount = 0;
                isCooldown = false;
            }
        }
            
        }
	}

