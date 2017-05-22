using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour {

	public GameObject misil;
	private float tiempoDeRecarga = 0f;
	private bool primerDisparo;

	void Start (){
		primerDisparo = true;
	}

	void Update () {
			tiempoDeRecarga += Time.deltaTime;
		if (Input.GetKeyDown (KeyCode.Space) && primerDisparo) {
			Instantiate (misil, transform.position, transform.rotation);
			primerDisparo = false;
		}
		if (Input.GetKeyDown (KeyCode.Space) && tiempoDeRecarga >= 1.5f && !primerDisparo) {
			Instantiate (misil, transform.position, transform.rotation);
			tiempoDeRecarga = 0;
		}
	}
}
