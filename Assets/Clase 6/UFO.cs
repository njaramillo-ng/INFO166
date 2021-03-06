﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UFO : MonoBehaviour {
	public int vida = 3;
	public float velocidad;
	public int direccion = 1;
	public AudioClip sonidoGolpe, sonidoExplosion;
	public AudioSource audioSource;
	public Text canvasWorldText, canvasScreenText, canvasMoveText;

	void Start(){
		UpdateUI();
	}
	
	void Update () {
		//movimiento considerando direccion
		transform.Translate(velocidad * Time.deltaTime * direccion,0,0);
		//invertir direccion al llegar al limite (8 y -8)
		if(transform.position.x >= 8)
			direccion = -1;
		else if(transform.position.x <= -8)
			direccion = 1;
		
		//revisar si la vida llega a 0 para destruirse
		if(vida <= 0)
			Destroy(gameObject);
	}

	void OnCollisionEnter(Collision c){
		//si es golpeado por una bala, reduce su vida en 1 y destruye la bala
		if(c.collider.tag == "Bala"){
			vida--;
			UpdateUI();
			audioSource.PlayOneShot(sonidoGolpe);
			Destroy(c.collider.gameObject);
		}
	}

	void UpdateUI(){
		canvasScreenText.text = canvasWorldText.text = canvasMoveText.text = "Vida UFO: "+vida;
	}

	void OnDestroy(){
		audioSource.PlayOneShot(sonidoExplosion);
	}

	void OnGUI(){
		GUI.Label(new Rect (0,0,100,50),"Vida UFO: "+vida);
	}
}
