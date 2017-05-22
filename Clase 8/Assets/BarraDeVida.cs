using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BarraDeVida : MonoBehaviour {

	public GameObject barraDeVidaParte1;
	public GameObject barraDeVidaParte2;
	public GameObject barraDeVidaParte3;
	private int contadorVecesQueChoca;
	private Scene escena;

	void Start ()
	{
		escena = SceneManager.GetActiveScene ();
	}

	void Update () {
		if (contadorVecesQueChoca == 1) {
			Destroy (barraDeVidaParte1);
		} else if (contadorVecesQueChoca == 2) {
			Destroy (barraDeVidaParte2);
		} else if (contadorVecesQueChoca >= 3){
			Destroy (barraDeVidaParte3);
			SceneManager.LoadScene (escena.name);
		}
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "Terreno") {
			contadorVecesQueChoca++;
		}
	}
}
