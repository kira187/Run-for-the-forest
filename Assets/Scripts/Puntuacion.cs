﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntuacion : MonoBehaviour
{

    private int puntuacion = 0;
    public TextMesh marcador;
    // Start is called before the first frame update
    void Start()
    {
        NotificationCenter.DefaultCenter().AddObserver(this, "IncrementarPuntos");
        ActualizarMarcador();
    }

    void IncrementarPuntos(Notification notification)
    {
        int puntosAIncrementar = (int)notification.data;
        puntuacion += puntosAIncrementar;
        ActualizarMarcador();
    }

    void ActualizarMarcador()
    {
        marcador.text = puntuacion.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}