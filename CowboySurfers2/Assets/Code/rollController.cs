﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rollController : MonoBehaviour {

    public static Animator roll;
    public KeyCode down;
    public GameObject myChildObject;
    public GameObject myParentObject;
    private bool rollLocked;
    

    // Use this for initialization
    void Start () {
        roll = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        
        
        
        if (Input.GetKeyDown(down) && rollLocked == false && GM.lvlCompStatus != "fail")
        {
            
            roll.Play("Roll");
            rollLocked = true;
            StartCoroutine(stopCrouch());
        }

        

    }




    IEnumerator stopCrouch()
    {

        yield return new WaitForSeconds(1.1f);


        if (GM.lvlCompStatus != "fail")
        { 
        myChildObject.transform.position = myParentObject.transform.position;
        myChildObject.transform.rotation = myParentObject.transform.rotation;
        rollLocked = false;
        roll.Play("Run");
        }
        
    }
}
