using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

	private int scoreGame;

	// Use this for initialization
	void Start () {
		scoreGame = int.Parse(gameObject.GetComponent<TextMesh>().text);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void upScoreGame(){
		scoreGame++;
		gameObject.GetComponent<TextMesh> ().text = scoreGame + "";
	}
}
