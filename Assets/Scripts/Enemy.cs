﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public float timeInitial;
	public float timeRepeting;
	public float velocityEnemy;
	private float posInitilEnemy;
	public int puntosVida;
	public GameObject prefabExplosion;
	public int puntosEnemy;
	public GameObject gameObjScoreGame;
	private Score scoreText;
	// Use this for initialization
	void Start () {
		scoreText = GameObject.FindGameObjectWithTag("score").GetComponent<Score>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate(){
		movEnemy ();
	}

	public void movEnemy(){
		posInitilEnemy = transform.position.y;
		gameObject.GetComponent<Rigidbody>().transform.Translate(Vector3.down * velocityEnemy * Time.deltaTime);
	}

	/*void OnTriggerEnter(Collider collision) {
		GameObject objetoColisionado = collision.gameObject;
		this.procesShoot(objetoColisionado);
	}*/

	void OnCollisionEnter(Collision collision) {
		GameObject objetoColisionado = collision.gameObject;
		this.procesShoot(objetoColisionado);

	}

	void procesShoot(GameObject objColisin){
		if(objColisin.tag=="disparo1"){
			puntosVida--;
			deadEnemy();
		}
	}

	/**
	 * Function make destruct enemy
	*/
	void deadEnemy(){
		if(puntosVida==0){
			if (scoreText == null) {
				GameObject objExplosion = Instantiate (prefabExplosion, transform.position, Quaternion.identity);
				Destroy (objExplosion, 1.0f);
				Destroy (this.gameObject);
			} else {
				scoreText.SendMessage ("upScoreGame");
				GameObject objExplosion = Instantiate (prefabExplosion, transform.position, Quaternion.identity);
				Destroy (objExplosion, 1.0f);
				Destroy (this.gameObject);
			}
		}
	}

	void createExplosion(){
		GameObject objExplosion = Instantiate(prefabExplosion,transform.position,Quaternion.identity);
		Destroy(objExplosion, 1.0f);
	}
}
