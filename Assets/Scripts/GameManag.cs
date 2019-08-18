using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManag : MonoBehaviour {
	public Text Score;
	// Use this for initialization
	void Start () {
		Score.text = "Level [" + PlayerPrefs.GetInt ("upDownScore") + "] - [" + PlayerPrefs.GetInt ("sideScore")+"]";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
