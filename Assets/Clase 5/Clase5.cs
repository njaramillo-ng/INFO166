using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clase5 : MonoBehaviour {
	//EJERCICIO: Crear un cañón que dispare balas (esferas) por sobre un muro, y que las esferas caigan al otro lado del muro.
	//Al chocar con el piso, se debe imprimir en consola el nombre del objeto del piso y además destruir la bala.
	public Vector3 force; //Vector3 para la fuerza
	public GameObject balaPrefab; //Prefab para la bala
	
	void Update () {
		//Al presionar una tecla, se crea una instancia de la bala en la posición de este objeto (el cañon).
		//Se guarda el GameObject instanciado en una variable (bala), y de ese GameObject se obtiene el Rigidbody.
		//Ese Rigidbody corresponde al de la bala instanciada, por lo que le aplicamos la fuerza correspondiente en modo impulso.
		if(Input.GetKeyDown(KeyCode.Space)){
			GameObject bala = (GameObject)Instantiate(balaPrefab,transform.position,transform.rotation);
			Rigidbody rbi = bala.GetComponent<Rigidbody>();
			rbi.AddForce(force,ForceMode.Impulse);
		}
	}
}
