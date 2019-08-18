using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topandbottom : MonoBehaviour {
	public GameObject upDownLayer;
	public bool isUp;
	void OnTriggerEnter2D(Collider2D other){
		if (isUp) {
		//	Debug.Log ("Upper");
			upDownLayer.transform.position = new Vector3 (transform.root.position.x, transform.root.position.y + 45.12f, transform.root.position.z);
		} else {
		//	Debug.Log ("Lower");
			upDownLayer.transform.position = new Vector3 (transform.root.position.x, transform.root.position.y - 45.12f, transform.root.position.z);
		}
	}
}
