using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GM : MonoBehaviour {

    public static float vertVel = 0;
    public static int coinTotal = 0;
    public static float timeTotal = 0;
    public static float zVelAdj = 1;

    public KeyCode dynamite;
    public KeyCode lasso;

    public float waitToLoad = 0;

    public static string lvlCompStatus = "";

    public Transform n1;
    public Transform n2;
    public Transform n3;
    public Transform n4;
    public Transform n5;
    public Transform n6;
    public Transform n7;
    public Transform n8;

    private float zScenePos = 20;

    public GameObject player;

    private bool dynamiteLocked = false;
    private bool lassoLocked = false;

	// Use this for initialization
	void Start () {
        

        /*Instantiate(bbNoPit, new Vector3(0, 0, 20), bbNoPit.rotation);
        Instantiate(Prefab_1, new Vector3(0, 0, 40), Prefab_1.rotation);
        Instantiate(Prefab_2, new Vector3(0, 0, 60), Prefab_2.rotation);
        Instantiate(Prefab_3, new Vector3(0, 0, 80), Prefab_3.rotation);
        Instantiate(Prefab_4, new Vector3(0, 0, 100), Prefab_4.rotation);
        Instantiate(Prefab_5, new Vector3(0, 0, 120), Prefab_5.rotation);
        Instantiate(Prefab_6, new Vector3(0, 0, 140), Prefab_6.rotation);*/
    }
	
	// Update is called once per frame
	void Update () {
        if (zScenePos < 120)
        {
            //Debug.Log(Math.random()*8); 
            //Instantiate(n + Math.random()*8, new Vector3(0, 0, zScenePos), n1.rotation);
            zScenePos += 20;
        }

        if (lvlCompStatus != "fail")
        {
            timeTotal += Time.deltaTime;

        }
       
		
        if (lvlCompStatus == "fail")
        {
            
            waitToLoad += Time.deltaTime;
        }

        if (waitToLoad > 2)
        {
            SceneManager.LoadScene("LevelComplete");
        }

        if (Input.GetKeyDown(dynamite) && !dynamiteLocked)
        {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("lethal");
            for (int i = 0; i < enemies.Length; i++)
            {
                float dist = Vector3.Distance(enemies[i].transform.position, player.transform.position);
                Debug.Log(dist);
                if (dist < 10)
                {
                    GameObject.Destroy(enemies[i]);
                    
                }
            }
            dynamiteLocked = true;
            StartCoroutine(DynamiteUnlock());
        }

        if (Input.GetKeyDown(lasso) && !lassoLocked)
        {
            
            GameObject[] bottle = GameObject.FindGameObjectsWithTag("bottles");
            for (int i = 0; i < bottle.Length; i++)
            {
                float dist = Vector3.Distance(bottle[i].transform.position, player.transform.position);
                Debug.Log(dist);
                if (dist < 10)
                {
                    GameObject.Destroy(bottle[i]);
                    GM.coinTotal++;
                }
            }
            lassoLocked = true;
            StartCoroutine(LassoUnlock());
        }

    }

    IEnumerator LassoUnlock()
    {
        yield return new WaitForSeconds(20);
        Debug.Log("works1");
        lassoLocked = false;
    }

    IEnumerator DynamiteUnlock()
    {
        yield return new WaitForSeconds(30);
        Debug.Log("works2");
        dynamiteLocked = false;
    }

   

    
}
