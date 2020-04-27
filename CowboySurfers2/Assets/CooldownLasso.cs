using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CooldownLasso : MonoBehaviour
{
    public Image imageCoolDown;
    private float cooldown = 20;
    bool isCooldown;




    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(GM.lasso))
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

