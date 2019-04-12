using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clase4 : MonoBehaviour {
	//EJERCICIO: Escribir un script que permita aplicar una fuerza (con un vector y un modo de fuerza) sobre dos objetos distintos.
	//Se deben usar dos teclas distintas (a elección) para determinar a cual de los dos objetos se le aplica la fuerza.
	//Además, con una tercera tecla se debe poder reiniciar la posición de los dos objetos
	//(a la posición que tienen cuando se ejecuta el juego) y dejarlos detenidos.

	public ForceMode modoFuerza; //Modo para aplicar la fuerza - se recomienda Impulse para que la fuerza se realice de golpe.
	public Vector3 fuerza; //Vector3 con los parametros de la fuerza, a eleccion
	public Rigidbody cubo; //Rigidbody correspondiente al primer objeto
	public Rigidbody capsula; //Rigidbody correspondiente al segundo objeto
	private Vector3 cuboPosInicial, capsulaPosInicial; //Vector3 para almacenar las posiciones iniciales de ambos objetos

	//Agregar un modo de rotación, activado desde el inspector, que funcione exactamente igual al ejercicio anterior
	//pero en vez de aplicar una fuerza, aplique un torque sobre cada objeto.
	public bool modoRotacion = false; //booleano que define si se utiliza rotacion/torque o no

	void Start(){
		//Al inciar el código, se almacenan las posiciones iniciales de ambos objetos en las variables que definimos para ello.
		cuboPosInicial = cubo.transform.position;
		capsulaPosInicial = capsula.transform.position;
	}
	
	void Update () {
		//Al presionar una tecla, se afecta al primer objeto
		if(Input.GetKeyDown(KeyCode.A)){
			//Si está en modo rotacion se realiza un torque, si no se realiza una fuerza
			if(modoRotacion)
				cubo.AddTorque(fuerza, modoFuerza);
			else
				cubo.AddForce(fuerza, modoFuerza);
		}

		//Lo mismo para el segundo objeto, pero utilizando otra tecla
		if(Input.GetKeyDown(KeyCode.D)){
			if(modoRotacion)
				capsula.AddTorque(fuerza, modoFuerza);
			else
				capsula.AddForce(fuerza, modoFuerza);
		}

		//Al presionar una tercera tecla, se reinician los objetos a su estado inicial
		if(Input.GetKeyDown(KeyCode.R)){
			//Se asigna la posicion inicial almacenada a los transform de ambos objetos
			capsula.transform.position = capsulaPosInicial;
			cubo.transform.position = cuboPosInicial;

			//Si los objetos han sido afectados por alguna fuerza o torque no basta solo devolverlos a la posicion inicial ya que la fuerza/torque
			//seguirá en efecto. También es necesario detenerlos.

			//Se debe setear su velocidad (lineal) al Vector3.zero (equivalente a (0,0,0)) para detener su movimiento.
			cubo.velocity = Vector3.zero;
			capsula.velocity = Vector3.zero;

			//También se debe setear su velocidad angular al Vector3.zero para detener su rotación.
			cubo.angularVelocity = Vector3.zero;
			capsula.angularVelocity = Vector3.zero;
		}			
	}
}
