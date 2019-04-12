using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerClase3 : MonoBehaviour {

	//OnTriggerEnter detecta cuando un objeto con colisionador entra al trigger.
	//Por lo menos uno de los dos objetos debe tener un rigidbody (en este caso, la esfera tiene un rigidbody).
	//El parámetro collider que lleva el método corresponde al collider del objeto que entró al trigger.
	void OnTriggerEnter(Collider collider){
		Debug.Log(collider.name + " entró al trigger.");
	}

	//Funciona igual que OnTriggerEnter, excepto que se ejecuta cuando un collider que ya se encuentra dentro del trigger sale.
	void OnTriggerExit(Collider collider){
		Debug.Log(collider.name + " salió del trigger.");
	}
}
