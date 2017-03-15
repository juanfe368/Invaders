using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Script que permite controlar las funciones del personaje principal
 * jfa
 * 2016-12-31
 * */
public class Player : MonoBehaviour {

	public float speedVelocity = 0f;
	private float movex = 0f;
	public Animator animPlayer;
	public int puntosDeVida;
	public GameObject prefabExplosion;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	void FixedUpdate(){
		MovPlayer();
	}

	/**
	 * Función que permite mover al personaje principal
	 * jfa
	 * 2016-31-12
	 * */
	public void MovPlayer(){
		//movex = Input.acceleration.x;
		movex = Input.GetAxis("Horizontal");
		if (movex == 1) {
			animPlayer.SetBool ("movRight", true);
			animPlayer.SetBool ("movLeft", false);
		} else if (movex == -1) {
			animPlayer.SetBool ("movRight", false);
			animPlayer.SetBool ("movLeft", true);
		} 
		else
		{
			animPlayer.SetBool ("movRight", false);
			animPlayer.SetBool ("movLeft", false);
			
		}
		float posX = transform.position.x + (movex * speedVelocity * Time.deltaTime);
		transform.position = new Vector3(Mathf.Clamp (posX, -8.20f, 8.20f), -4.0f, 0f);
		//Debug.Log ("Este es el valor del axis: " + movex+" Esta es la posición del jugador: "+transform.position.x);
	}

	void OnTriggerEnter(Collider collision) {
		GameObject objColision = collision.gameObject;
		if(objColision.tag=="Enemy1"){
			puntosDeVida--;
			if(puntosDeVida==0){
				deadPlayer();
			}
		}
		else if(objColision.tag=="asteroide"){
			puntosDeVida--;
			if(puntosDeVida==0){
				deadPlayer();
			}
		}
	}

	/*void OnCollisionEnter(Collision collision) {
		Debug.Log("Entro al enter");
		GameObject objColision = collision.gameObject;
		if(objColision.tag=="Enemy1"){
			puntosDeVida--;
			if(puntosDeVida==0){
				deadPlayer();
			}
		}
	}*/

	void subtractPlayer(){
		Debug.Log("Entro al herir enemigo");
	}

	void deadPlayer(){
		GameObject objExplosion = Instantiate(prefabExplosion,transform.position,Quaternion.identity);
		Destroy(objExplosion, 1.0f);
		Destroy(this.gameObject);
		Application.LoadLevel("World1");
	}
}
