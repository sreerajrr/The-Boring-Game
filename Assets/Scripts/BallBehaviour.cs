using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class BallBehaviour : MonoBehaviour {
	float dirX,dirY;
	Rigidbody2D rb;
	public float speedOfBall;
	public float rotatespeed;
	float p;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		//rb.velocity= new Vector2 (1f, 0);
		//dirX = 1f;
	}
	
	// Update is called once per frame
	void Update () {
		dirX = CrossPlatformInputManager.GetAxis ("Horizontal");

		dirY = CrossPlatformInputManager.GetAxis ("Vertical");
		p = Mathf.Sqrt ((dirX * dirX) + (dirY * dirY));
		transform.Rotate (Vector3.back * Time.deltaTime*rotatespeed*speedOfBall*p);

		rb.velocity = new Vector2 (dirX * speedOfBall, dirY * speedOfBall);
	}
}
