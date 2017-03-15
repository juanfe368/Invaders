using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroide : MonoBehaviour {

	private float posInitilEnemy;
	public float velocityEnemy;
	public int puntosEnemy;
	public GameObject prefabExplosion;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate(){
		movEnemy ();
	}

	/*void OnCollisionEnter(Collision collision) {
		GameObject objetoColisionado = collision.gameObject;
		Debug.Log ("Entro al colisionador");
		if(objetoColisionado.tag=="Enemy1"){
			Debug.Log ("Choque con enemigo");
			Enemy enemyColisionado = objetoColisionado.GetComponent<Enemy>();
			enemyColisionado.puntosVida = 0;
			enemyColisionado.SendMessage("deadEnemy");
		}
	}*/

	void OnTriggerEnter(Collider collision) {
		GameObject objetoColisionado = collision.gameObject;
		if(objetoColisionado.tag=="Enemy1"){
			Enemy enemyColisionado = objetoColisionado.GetComponent<Enemy>();
			enemyColisionado.puntosVida = 0;
			enemyColisionado.SendMessage("deadEnemy");
		}
		else if(objetoColisionado.tag=="Enemy"){
			Enemy enemyColisionado = objetoColisionado.GetComponent<Enemy>();
			enemyColisionado.puntosVida = 0;
			enemyColisionado.SendMessage("deadEnemy");
		}
		else if(objetoColisionado.tag=="disparo1"){
			puntosEnemy--;
			if(puntosEnemy==0){
				destructAsteroide();
				Destroy(this.gameObject);
			}
		}
	}

	public void movEnemy(){
		posInitilEnemy = transform.position.y;
		gameObject.GetComponent<Rigidbody>().transform.Translate(Vector3.down * velocityEnemy * Time.deltaTime);
	}

	public void destructAsteroide(){
		GameObject objExplosion = Instantiate(prefabExplosion,transform.position,Quaternion.identity);
		Destroy(objExplosion, 1.0f);
	}
}
