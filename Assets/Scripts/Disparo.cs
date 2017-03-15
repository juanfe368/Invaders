using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour {

	public float velocityDisparo;
	public float tilt;
	public GameObject disparadorObjt;
	// Use this for initialization
	void Start () {
		disparadorObjt = GameObject.FindGameObjectWithTag("disparador");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate ()
	{
		ShootingAutomatic();
	}

	public void ShootingAutomatic(){
		gameObject.GetComponent<Rigidbody>().transform.Translate(Vector3.up * velocityDisparo * Time.deltaTime);
	}

	void OnBecameInvisible () {
		Destroy(this.gameObject);
	}

	void OnCollisionEnter(Collision collision) {
		Destroy(this.gameObject);
	}

	/*void OnTriggerEnter(Collider collision) {
		Destroy(this.gameObject);
	}*/
}
