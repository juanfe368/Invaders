using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision) {
		GameObject objetoColisionado = collision.gameObject;
		Destroy(objetoColisionado);
		/*Debug.Log("Este es el tag del que entro: "+objetoColisionado.tag);
		if(objetoColisionado.tag=="disparo1"){
			Destroy(objetoColisionado);
		}
		else if(objetoColisionado.tag=="Enemy1"){
			Destroy(objetoColisionado);
		}*/

	}

	void OnTriggerEnter(Collider collision) {
		GameObject objetoColisionado = collision.gameObject;
		Destroy(objetoColisionado);
	}
}
