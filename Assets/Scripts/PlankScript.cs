﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlankScript : MonoBehaviour {

    public AudioSource bumpSoundEffect;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag != "Plank")
        {
           // bumpSoundEffect.Play();
        }
    }
}
