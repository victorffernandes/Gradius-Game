﻿using UnityEngine;
using System.Collections;

public class Space_Move : Default {
    public float r;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.renderer.material.mainTextureOffset -= new Vector2(-1 * Mathf.Pow( Time.deltaTime,r),0);
	}
} 
