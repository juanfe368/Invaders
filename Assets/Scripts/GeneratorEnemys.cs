using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorEnemys : MonoBehaviour {

	public GameObject prefabEnemy1;
	public float initialGeneretor;
	public float resumeGeneretor;
	public float minPosX;
	public float maxPosX;

	// Use this for initialization
	void Start () {
		InvokeRepeating("GeneratorEnemyPos", initialGeneretor, resumeGeneretor);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	/**
	 * Función que permite generar enemigos dinamicamente
	 * 2016-01-02
	 * jfa
	*/
	public void GeneratorEnemyPos(){
		float posXEnemy = Random.Range(minPosX, maxPosX);
		Vector3 vectorTemp = new Vector3(posXEnemy,transform.position.y,0);
		Instantiate(prefabEnemy1, vectorTemp, Quaternion.identity);
	}
}
