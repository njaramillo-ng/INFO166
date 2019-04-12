using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clase2 : MonoBehaviour {
	//EJERCICIO 1
	//Mediante código, rotar un objeto constantemente en una dirección (puede ser uno o más ejes).
	//Desafío: Modificar el código anterior de manera que además de rotar en una dirección, se pueda invertir la dirección de la rotación
	//(desde el Inspector, no modificando el código mientras se ejecuta).

	//Variables
	public Transform cubo; //Transform del objeto a rotar
	public int direccionRotacion = 1; //Entero que define la direccion de la rotacion
									  //Positivo: rota hacia la izquierda
								      //Negativo: rota hacia la derecha

	//EJERCICIO 2
	//Mediante código, hacer que un objeto se mueva desde un extremo a otro de la pantalla
	//(manteniendo la cámara fija) mediante el uso de algún tipo de input.
	public Transform esfera; //Transform del objeto a mover
	public float velocidadMovimiento = 5; //Float que sirve para definir la velocidad de movimiento del objeto


	// Update is called once per frame
	void Update () {
		//se rota el objeto solo en torno al eje Y
		cubo.Rotate(0, direccionRotacion, 0);

		//Siempre utilizar Time.deltaTime y una variable de velocidad para mover un objeto de manera estable, independiente del framerate
		esfera.Translate(Input.GetAxisRaw("Horizontal") * Time.deltaTime * velocidadMovimiento,0,0);
	}
}
