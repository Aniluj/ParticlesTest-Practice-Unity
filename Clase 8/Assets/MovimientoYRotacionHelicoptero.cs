using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoYRotacionHelicoptero : MonoBehaviour {

	public float velocidadDeMovimientoFrontalYLateral;
	public float velocidadDeMovimientoVertical;
	public float velocidadDeRotacion;

	void FixedUpdate () {
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (-Vector3.forward * velocidadDeMovimientoFrontalYLateral * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (Vector3.forward * velocidadDeMovimientoFrontalYLateral * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate (-Vector3.up * velocidadDeRotacion * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate (Vector3.up * velocidadDeRotacion * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (Vector3.up * velocidadDeMovimientoVertical * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (-Vector3.up * velocidadDeMovimientoVertical * Time.deltaTime);
		}
	}
}
