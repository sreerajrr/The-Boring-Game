using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftandRight : MonoBehaviour {

	public GameObject leftRightLayer;
	public bool isRight;
	void OnTriggerEnter2D(Collider2D other){
		if (isRight) {
			//Debug.Log ("Right");
			leftRightLayer.transform.position = new Vector3 (transform.root.position.x + 27.52f, transform.root.position.y, transform.root.position.z);
		} else {
			//Debug.Log ("Left");
			leftRightLayer.transform.position = new Vector3 (transform.root.position.x - 27.52f, transform.root.position.y, transform.root.position.z);
		}
	}
}
