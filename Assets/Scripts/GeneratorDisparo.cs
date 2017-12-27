using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorDisparo : MonoBehaviour {

	public GameObject disparo;
	public float timeInitial;
	public float timeInvoke;
	public float timeMinGenerator;
	public float timeMaxGenerator;

	// Use this for initialization
	void Start () {
		this.GenerateShoot(this.timeInitial, this.timeInvoke);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GeneratorShootAutomatic(){
		GameObject disparoGeneretor = Instantiate(disparo, transform.position, Quaternion.identity);
	}
		
	public void hightVelocity(){
		if(this.timeInvoke>timeMinGenerator){
			CancelInvoke("GeneratorShootAutomatic");
			this.timeInvoke -= 0.1f;
			this.GenerateShoot(this.timeInvoke, this.timeInvoke);
		}
	}

	public void GenerateShoot(float timeInitial, float timeInvoke){
		InvokeRepeating("GeneratorShootAutomatic", timeInitial, timeInvoke);
	}
}
