using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {
    public static AudioClip jump,slide;
    static AudioSource audioSrc;
	// Use this for initialization
	void Start () {
        jump = Resources.Load<AudioClip>("AlternativeJumpSound");
        slide = Resources.Load<AudioClip>("slide");
        audioSrc = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public static void playSound (string clip)
    {
        switch (clip)
        {
            case "AlternativeJumpSound":
                audioSrc.PlayOneShot(jump);
                break;
            case "slide":
                audioSrc.PlayOneShot(slide);
                break;
       
        }
    }
}
