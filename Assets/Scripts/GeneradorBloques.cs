﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorBloques : MonoBehaviour
{
    public GameObject[] obj;
    public float tiempoMin = 1f;
    public float tiempoMax = 2f;
    private bool fin = false;

    void Start()
    {
        Generar();
        //NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeEmpiezaAcorrer");
        NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeHaMuerto");
    }

    void PersonajeHaMuerto()
    {
        fin = true;
    }

    void PersonajeEmpiezaAcorrer()
    {
        Generar();
    }
    
    //Generador de bloques
    void Generar()
    {
        if (!fin)
        {
            Instantiate(obj[Random.Range(0, obj.Length)], transform.position, Quaternion.identity);
            Invoke("Generar", Random.Range(tiempoMin, tiempoMax));
        }
    }
}
