using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rollController : MonoBehaviour {

    public Animator roll;
    public KeyCode down;
    public GameObject myChildObject = new GameObject();
    public GameObject myParentObject = new GameObject();
    public bool rollLocked;
    

    // Use this for initialization
    void Start () {
        roll = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        
        
        
        if (Input.GetKeyDown(down) && rollLocked == false)
        {
            
            roll.Play("Roll");
            rollLocked = true;
            StartCoroutine(stopCrouch());
        }
        
    }

    IEnumerator stopCrouch()
    {
        yield return new WaitForSeconds(1.1f);

        float horizontal = myParentObject.transform.position.x;
        myChildObject.transform.position = new Vector3(horizontal, transform.position.y, transform.position.z);
        myChildObject.transform.rotation = myParentObject.transform.rotation;
        rollLocked = false;
        roll.Play("Run");
    }
}
