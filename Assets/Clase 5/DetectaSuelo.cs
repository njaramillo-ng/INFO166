using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectaSuelo : MonoBehaviour {

	//En este caso el script va en la bala, por lo que debe detectar si colisiona con el suelo
	void OnCollisionEnter(Collision c){
		//Si el tag del colisonador coincide con el que usamos para el suelo, imprime el nombre del objeto del suelo y además se destruye la bala.
		if(c.collider.tag == "Ground"){
			Debug.Log(c.collider.name);
			Destroy(gameObject);
		}
	}
}
