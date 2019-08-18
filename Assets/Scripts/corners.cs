using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class corners : MonoBehaviour {

	public GameObject cornerLayer;
	public bool isright;
	public bool isUp;
	void OnTriggerEnter2D(Collider2D other){
		
		if (isright && isUp) {
			//	Debug.Log ("UPRight");
				cornerLayer.transform.position = new Vector3 (transform.root.position.x + 27.52f, transform.root.position.y + 45.12f, transform.root.position.z);
		} 
		else if(!isright && isUp) {
				//Debug.Log ("UpLeft");
				cornerLayer.transform.position = new Vector3 (transform.root.position.x - 27.52f, transform.root.position.y + 45.12f, transform.root.position.z);

		} 
		else if (isright && !isUp) {
				//Debug.Log ("BottomRight");
				cornerLayer.transform.position = new Vector3 (transform.root.position.x + 27.52f, transform.root.position.y - 45.12f, transform.root.position.z);
			} 
		else if(!isright && !isUp) {
			//	Debug.Log ("BottomLeft");
				cornerLayer.transform.position = new Vector3 (transform.root.position.x - 27.52f, transform.root.position.y - 45.12f, transform.root.position.z);
			}
		
	}
}
