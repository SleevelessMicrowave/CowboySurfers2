using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RecyclingFacts : MonoBehaviour {

    private string[] recyclingFacts = new string [20];
    private int num;

    // Use this for initialization
    void Start () {

        recyclingFacts[0] = "U.S. recycling levels are currently 21.4%";
        recyclingFacts[1] = "When U.S. recycling levels reach 75% it will be the environmental equivalent of removing 55 million cars from U.S. roads each year";
        recyclingFacts[2] = "The U.S. recycling levels have not improved in 20 years despite the billions of dollars spent on the industry";
        recyclingFacts[3] = "Americans throw away 2.5 million plastic bottles every hour";
        recyclingFacts[4] = "Recycling one ton of plastic bottles saves enough energy to power a two person household for one year";
        recyclingFacts[5] = "Americans throw away enough office paper each year to build a 12 foot high wall from Seattle to NYC";
        recyclingFacts[6] = "Americans throw away enough plastic bottles each year to circle the earth four times";
        recyclingFacts[7] = "The EPA estimates that 75% of the American waste stream is recyclable, but we only recycle about 30% of it";
        recyclingFacts[8] = "The 36 billion aluminum cans landfilled last year had a scrap value of more than $600 million";
        recyclingFacts[9] = "In 2010, paper recycling had increased over 89% since 1990";
        recyclingFacts[10] = "90% of all solid waste in the United States does not get recycled";
        recyclingFacts[11] = "Landfills are among the biggest contributors to soil pollution – roughly 80% of the items could be recycled";
        recyclingFacts[12] = "Recycling plastic saves twice as much energy as it takes to burn it";
        recyclingFacts[13] = "It takes 500 years for average sized plastic water bottles to fully decompose";
        recyclingFacts[14] = "Buy recycled paper and print on both sides";
        recyclingFacts[15] = "Make recycling bins readily available";
        recyclingFacts[16] = "Recycle your empty ink and toner cartridges";
        recyclingFacts[17] = "Recycle old newspaper laying around the office";
        recyclingFacts[18] = "Look for the recycled option in all the products you buy";
        recyclingFacts[19] = "Buy rechargeable batteries";
        

        num = Random.Range(0, 20);

        StartCoroutine(loadTime());

    }

    // Update is called once per frame
    void Update () {
        if (gameObject.name == "Facts")
        {
            
            GetComponent<Text>().text = recyclingFacts[num];
        }

    }

    IEnumerator loadTime()
    {

        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Main");
    }
}
