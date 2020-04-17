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

    public GameObject[] routes = new GameObject[7];

    private float zScenePos = 20;
    private float zScenePosLimit = 40;

    public GameObject player;

    private bool dynamiteLocked = false;
    private bool lassoLocked = false;

	// Use this for initialization
	void Start () {
        

        
    }
	
	// Update is called once per frame
	void Update () {
        if (timeTotal < zScenePosLimit)
        {
            int num = Random.Range(0, 7);
            Instantiate(routes[num], new Vector3(0, 0, zScenePos), routes[0].transform.rotation);
            zScenePos += 20;
            if (zScenePosLimit - 20 == timeTotal)
            {
                zScenePosLimit += 60;
            }
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
