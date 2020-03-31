using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rollController : MonoBehaviour {

    public Animator roll;
    public KeyCode down;

    // Use this for initialization
    void Start () {
        roll = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(down))
        {
            roll.Play("Roll");
            StartCoroutine(stopCrouch());
        }
        
    }

    IEnumerator stopCrouch()
    {
        yield return new WaitForSeconds(1.1f);
        roll.Play("Run");
    }
}
