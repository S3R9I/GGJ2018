﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnGearScript : MonoBehaviour {
    public float gearSpeed;
    public float multiply;
    public bool isActive;
	// Use this for initialization
	void Start () {
        Debug.Log(transform.localScale.x);
		
	}
	
	// Update is called once per frame
	void Update () {

        if(isActive)
        {
            transform.Rotate(0, 0, (gearSpeed * transform.localScale.x) * multiply);
        }

  
	}
}
