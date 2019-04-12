using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reloj : MonoBehaviour {
	public Transform hora, minuto, segundo; //Transform que contienen el horario, minutero y segundero.
											//No los mismos objetos, sino los objetos vacios que los contienen y que sirven como pivote
	private float rotacionHora = 360f/12f; //La cantidad de grados que rota el horario al avanzar (360 grados dividido por la cantidad de horas en un reloj)
	private float rotacionMinSeg = 360f/60f; //La cantidad de grados que rota el minutero al avanzar (360 grados dividido por la cantidad de minutos en un reloj)
											 //La misma variable sirve para el segundero
	void Update () {
		//Se obtiene la hora actual
		System.DateTime horaActual = System.DateTime.Now;
		//Los angulos en Unity funcionan con rotacion tipo mano derecha, por lo que la rotacion positiva se realiza hacia la izquierda
		//Por ende, se multiplica por el valor negativo de la rotacion por unidad para que se rote hacia la derecha
		//las variables Hour, Minute y Second de un System.DateTime son enteros que retornan la hora, minuto y segundo actual respectivamente.
		hora.eulerAngles = new Vector3(0,0,horaActual.Hour * -rotacionHora);
		minuto.eulerAngles = new Vector3(0,0,horaActual.Minute * -rotacionMinSeg);
		segundo.eulerAngles = new Vector3(0,0,horaActual.Second * -rotacionMinSeg);
	}
}
