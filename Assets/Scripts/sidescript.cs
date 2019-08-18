using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sidescript : MonoBehaviour {

	public GameObject otherslide;
	public bool isRight;
	// Use this for initialization
	void Start () {
		Debug.Log ("Working");

	}

	// Update is called once per frame
	void Update () {

	}


	void OnTriggerEnter2D(Collider2D coll){
		Debug.Log ("Working");
		if(isRight)
			otherslide.transform.position = new Vector3 (transform.root.position.x+27.52f, transform.root.position.y, transform.root.position.z);
		else
			otherslide.transform.position = new Vector3 (transform.root.position.x-27.52f, transform.root.position.y, transform.root.position.z);

	}
}
