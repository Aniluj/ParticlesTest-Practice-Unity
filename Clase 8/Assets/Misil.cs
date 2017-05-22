using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Misil : MonoBehaviour {

	public float fuerzaDeDisparo;
	public Transform terreno;

	void Start () 
	{
		Rigidbody misil = GetComponent<Rigidbody> ();
		misil.AddRelativeForce (Vector3.forward * fuerzaDeDisparo, ForceMode.Impulse);
	}

	void OnCollisionEnter (Collision col)
	{
		Destroy (gameObject);
	}
}
