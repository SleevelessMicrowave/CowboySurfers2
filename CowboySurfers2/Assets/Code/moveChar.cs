using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class moveChar : MonoBehaviour {

    public KeyCode moveL;
    public KeyCode moveR;
    public KeyCode jump;
    public KeyCode down;

    public float horizVel = 0;
    public float vertVel = 0;
    public int laneNum = 2;
    public bool controlLocked = false;
    public bool crouchLocked = false;
    public bool jumpLocked = false;

    public GameObject cowboy;
    public GameObject sphere;
    public GameObject cube;

    public Transform boomObj;

    bool isGrounded;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {

        GetComponent<Rigidbody>().velocity = new Vector3(horizVel, GM.vertVel, 4);

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (sphere != null)
        { 
        sphere.transform.rotation = cube.transform.rotation;
        }

        if ((Input.GetKeyDown(moveL) && (laneNum > 1) && controlLocked == false))
        {
            horizVel = -2;
            StartCoroutine(StopSlide());
            laneNum--;
            controlLocked = true;
        }

        if ((Input.GetKeyDown(moveR) && (laneNum < 3) && controlLocked == false))
        {
            horizVel = 2;
            StartCoroutine(StopSlide());
            laneNum++;
            controlLocked = true;
        }

        if (Input.GetKeyDown(jump) && isGrounded && jumpLocked == false)
            {
            GM.vertVel = 3;
            StartCoroutine(StopJump());
            jumpLocked = true;
        }

        if (Input.GetKeyDown(down) && crouchLocked == false && jumpLocked == false)
        {
            
            gameObject.transform.localScale = new Vector3(0.8749517f, 0.5f, .8749518f);
            Vector3 position = gameObject.transform.position;
            position[1] = .955f;
            gameObject.transform.position = position;
            crouchLocked = true;
            StartCoroutine(StopCrouch());
            
            
        }
        
    }

    private void OnCollisionEnter(Collision other)
    {
        
        if (other.gameObject.tag == "lethal")
        {

            Destroy(gameObject);
            Destroy(cowboy);
            GM.zVelAdj = 0;
            Instantiate(boomObj, transform.position, boomObj.rotation);
            GM.lvlCompStatus = "fail";
            
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "rampBottomTrig")
        {
            GM.vertVel = 1;
        }
        if (other.gameObject.name == "rampTopTrig")
        {
            GM.vertVel = 0;
        }
        if (other.gameObject.name == "exit")
        {
            SceneManager.LoadScene("LevelComplete");
        }
        if (other.gameObject.name == "waterBottle")
        {
            Destroy(other.gameObject);
            GM.coinTotal++;
        }
        
    }

    IEnumerator StopSlide()
    {
        yield return new WaitForSeconds(.5f);
        horizVel = 0;
        vertVel = 0;
        controlLocked = false;
    }

    IEnumerator StopJump()
    {
        yield return new WaitForSeconds(.35f);
        GM.vertVel = -3;
        yield return new WaitForSeconds(.35f);
        GM.vertVel = 0;
        jumpLocked = false;
    }

    IEnumerator StopCrouch()
    {
        yield return new WaitForSeconds(1.1f);
        Vector3 position = gameObject.transform.position;
        position[1] = 1.133f;
        gameObject.transform.position = position;
        gameObject.transform.localScale = new Vector3(0.8749517f, 0.8838291f, .8749518f);
        crouchLocked = false;
    }
}
