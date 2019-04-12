using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clase3 : MonoBehaviour {
	//Crear un trigger que imprima en consola un mensaje cuando un objeto entre y salga de su volumen.
	//Además, crear un objeto que se mueva mediante input del usuario para probar el funcionamiento del Trigger.
	public Transform esfera; //Transform del objeto a mover
	public float velocidadMovimiento = 5; //Float que sirve para definir la velocidad de movimiento del objeto

	void Update () {
		esfera.Translate(Input.GetAxisRaw("Horizontal") * Time.deltaTime * velocidadMovimiento,0,0);
	}
}
