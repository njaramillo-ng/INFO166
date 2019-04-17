using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cañon : MonoBehaviour {
	public float velocidadRotacion = 50;
	public float fuerzaDisparo = 20;
	public GameObject bala;
	public Transform bocaCañon;
	public Transform ejeCañon;
	
	void Update () {
		//Rotar horizontal (torreta)
		transform.Rotate(0,Input.GetAxis("Horizontal") * Time.deltaTime * velocidadRotacion,0);

		//Rotar vertical (eje cañon)
		//se guarda la rotacion actual del eje en grados (eulerAngles)
		Vector3 rot = ejeCañon.eulerAngles;
		//se modifica la rotacion del eje actual en grados en el eje x aplicando la nueva posicion esperada, pero utilizando Clamp para mantenerla entre 0 y 50
		//los valores de los ejes y & z se mantienen iguales
		ejeCañon.eulerAngles = new Vector3(Mathf.Clamp(rot.x + Input.GetAxis("Vertical") * Time.deltaTime * velocidadRotacion/2, 0, 50),rot.y,rot.z);

		//disparar
		if(Input.GetKeyDown(KeyCode.Space)){
			//instancia una copia del prefab bala y lo guarda en un gameobject nuevo
			GameObject nuevaBala = (GameObject)Instantiate(bala,bocaCañon.position,bocaCañon.rotation);
			//obtiene el rigidbody de la bala nueva
			Rigidbody rbBala = nuevaBala.GetComponent<Rigidbody>();
			//le aplica una fuerza al rigidbody de la bala
			rbBala.AddForce(bocaCañon.forward * fuerzaDisparo,ForceMode.Impulse);
		}	
	}
}
