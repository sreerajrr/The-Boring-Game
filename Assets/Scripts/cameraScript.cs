﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour {
	public GameObject ball;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		gameObject.transform.position =new Vector3(ball.transform.position.x,ball.transform.position.y,ball.transform.position.z-10f);
	}
}
