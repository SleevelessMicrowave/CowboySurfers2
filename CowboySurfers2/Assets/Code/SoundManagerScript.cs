﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {
    public static AudioClip jump,slide,explosion,whoosh,death,pop;
    static AudioSource audioSrc;
	// Use this for initialization
	void Start () {
        jump = Resources.Load<AudioClip>("AlternativeJumpSound");
        slide = Resources.Load<AudioClip>("slide");
        explosion = Resources.Load<AudioClip>("explosion");
        whoosh = Resources.Load<AudioClip>("whoosh");
        death = Resources.Load<AudioClip>("death");
        pop = Resources.Load<AudioClip>("pop");
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
            case "explosion":
                audioSrc.PlayOneShot(explosion);
                break;
            case "whoosh":
                audioSrc.PlayOneShot(whoosh);
                break;
            case "death":
                audioSrc.PlayOneShot(death);
                break;
            case "pop":
                audioSrc.PlayOneShot(pop);
                break;
        }
    }
}
