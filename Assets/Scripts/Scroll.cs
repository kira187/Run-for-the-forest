using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour {

	public bool IniciarEnMovimiento = false;
	public float velocidad = 0f;
	private bool enMovimiento = false;
	private float tiempoInicio = 0f;
	
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeEmpiezaAcorrer");
		NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeHaMuerto");
		if (IniciarEnMovimiento) {
            PersonajeEmpiezaAcorrer();
		}
	}

	void PersonajeHaMuerto(){
		enMovimiento = false;
	}

	void PersonajeEmpiezaAcorrer(){
		enMovimiento = true;
		tiempoInicio = Time.time;
	}
	
	void Update () {
		if(enMovimiento){
			GetComponent<Renderer>().material.mainTextureOffset = new Vector2(((Time.time - tiempoInicio) * velocidad) % 1, 0);
		}
	}
}
