using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorDisparo : MonoBehaviour {

	public GameObject disparo;
	public float timeInitial;
	public float timeInvoke;

	// Use this for initialization
	void Start () {
		InvokeRepeating("GeneratorShootAutomatic", timeInitial, timeInvoke);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GeneratorShootAutomatic(){
		GameObject disparoGeneretor = Instantiate(disparo, transform.position, Quaternion.identity);
	}
}
