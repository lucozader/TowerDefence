﻿using UnityEngine;
using System.Collections;

public class UFO : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
			gameObject.transform.Translate(-0.05f,0f,0f,Space.World);

	}
}
