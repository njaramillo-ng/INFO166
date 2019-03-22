using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reloj : MonoBehaviour {

	public Transform hora, minuto, segundo;
	private float rotacionHora = 360f/12f;
	private float rotacionMinSeg = 360f/60f;

	void Update () {
		System.DateTime horaActual = System.DateTime.Now;
		hora.eulerAngles = new Vector3(0,0,horaActual.Hour * -rotacionHora);
		minuto.eulerAngles = new Vector3(0,0,horaActual.Minute * -rotacionMinSeg);
		segundo.eulerAngles = new Vector3(0,0,horaActual.Second * -rotacionMinSeg);
	}
}
