using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updownnewlayer : MonoBehaviour {
	public GameObject otherslide;
	public bool bottom;
	// Use this for initialization
	void Start () {
		Debug.Log ("Working");

	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter2D(Collider2D coll){
		Debug.Log ("Working");
		if(bottom)
			otherslide.transform.position = new Vector3 (transform.root.position.x, transform.root.position.y-45.13f, transform.root.position.z);
		else
			otherslide.transform.position = new Vector3 (transform.root.position.x, transform.root.position.y+45.13f, transform.root.position.z);
			
	}
}
