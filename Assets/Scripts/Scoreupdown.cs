using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreupdown : MonoBehaviour {
	public bool isbottom;
	public Text Score;
	bool fromRight,fromLeft,fromTop,fromBottom;
	// Use this for initialization
	void Start () {
		fromRight = false;
		fromLeft = false;
		fromTop = false;
		fromBottom = false;
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter2D (Collider2D col){
		if (!isbottom) {
			if (col.gameObject.transform.position.x < transform.position.x) {
				fromLeft = true;
				Debug.Log ("fromLeft");
		//		PlayerPrefs.SetInt ("sideScore", PlayerPrefs.GetInt ("sideScore") + 1);
			//	Score.text = "Level " + PlayerPrefs.GetInt ("upDownScore") + " - " + PlayerPrefs.GetInt ("sideScore");
			} else if (col.gameObject.transform.position.x > transform.position.x) {
				fromRight = true;
				Debug.Log ("fromRight");
			//	PlayerPrefs.SetInt ("sideScore", PlayerPrefs.GetInt ("sideScore") - 1);
			//	Score.text = "Level " + PlayerPrefs.GetInt ("upDownScore") + " - " + PlayerPrefs.GetInt ("sideScore");
			}
		}
		if (isbottom) {
			if (col.gameObject.transform.position.y < transform.position.y) {
				fromBottom = true;
				Debug.Log ("fromBottom");
				//		PlayerPrefs.SetInt ("sideScore", PlayerPrefs.GetInt ("sideScore") + 1);
				//	Score.text = "Level " + PlayerPrefs.GetInt ("upDownScore") + " - " + PlayerPrefs.GetInt ("sideScore");
			} else if (col.gameObject.transform.position.y > transform.position.y){
				fromTop = true;
				Debug.Log ("from Top");
				//	PlayerPrefs.SetInt ("sideScore", PlayerPrefs.GetInt ("sideScore") - 1);
				//	Score.text = "Level " + PlayerPrefs.GetInt ("upDownScore") + " - " + PlayerPrefs.GetInt ("sideScore");
			}
		}
	}

	void OnTriggerExit2D (Collider2D col){
		if (fromLeft) {
			fromLeft = false;
			if (col.gameObject.transform.position.x > transform.position.x) {
				Debug.Log ("Exiting from Left");
				PlayerPrefs.SetInt ("sideScore", PlayerPrefs.GetInt ("sideScore") +1);
				Score.text = "Level [" + PlayerPrefs.GetInt ("upDownScore") + "] - [" + PlayerPrefs.GetInt ("sideScore")+"]";
			}
		}
			if (fromRight) {
			fromRight = false;
				if (col.gameObject.transform.position.x < transform.position.x) {
					Debug.Log ("Exiting fromRight");
					PlayerPrefs.SetInt ("sideScore", PlayerPrefs.GetInt ("sideScore") -1 );
					Score.text = "Level [" + PlayerPrefs.GetInt ("upDownScore") + "] - [" + PlayerPrefs.GetInt ("sideScore")+"]";
				}
			}
		if (fromTop) {
			fromTop = false;
			if (col.gameObject.transform.position.y < transform.position.y) {
				Debug.Log ("Exiting from fromTop");
				PlayerPrefs.SetInt ("upDownScore", PlayerPrefs.GetInt ("upDownScore") -1);
				Score.text = "Level [" + PlayerPrefs.GetInt ("upDownScore") + "] - [" + PlayerPrefs.GetInt ("sideScore")+"]";
			}
		}
		if (fromBottom) {
			fromBottom = false;
			if (col.gameObject.transform.position.y > transform.position.y) {
				Debug.Log ("Exiting fromBottom");
				PlayerPrefs.SetInt ("upDownScore", PlayerPrefs.GetInt ("upDownScore") +1 );
				Score.text = "Level [" + PlayerPrefs.GetInt ("upDownScore") + "] - [" + PlayerPrefs.GetInt ("sideScore")+"]";
			}
		}

		}
	

}
