using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorDisparo : MonoBehaviour {

	public GameObject disparo;
	public float timeInitial;
	public float timeInvoke;
	public float timeMinGenerator;
	public float timeMaxGenerator;
	private bool stopHightGenetor;

	// Use this for initialization
	void Start () {
		stopHightGenetor = false;
		InvokeRepeating("GeneratorShootAutomatic", timeInitial, timeInvoke);
	}
	
	// Update is called once per frame
	void Update () {
		if(timeInvoke>timeMaxGenerator){
			InvokeRepeating("GeneratorShootAutomatic", timeInvoke, timeInvoke);
		}
	}

	public void GeneratorShootAutomatic(){
		GameObject disparoGeneretor = Instantiate(disparo, transform.position, Quaternion.identity);
	}

	public void hightVelocity(){
		if(!stopHightGenetor){
			timeInvoke -= 0.01f;
			if(timeInvoke<=timeMinGenerator){
				stopHightGenetor = true;
			}
		}
	}
}
