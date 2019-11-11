using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntuacion : MonoBehaviour
{
    private int puntuacion = 0;
    public TextMesh marcador;
  
    void Start()
    {
        NotificationCenter.DefaultCenter().AddObserver(this, "IncrementarPuntos");
        NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeHaMuerto");
        ActualizarMarcador();
    }

    void PersonajeHaMuerto(Notification notification)
    {
        if (puntuacion > EstadoJuego.estadoJuego.puntuacionMaxima)
        {
            //Debug.Log("Puntuacion maxima superada!!!"+ EstadoJuego.estadoJuego.puntuacionMaxima+ "Actual"+puntuacion);
            EstadoJuego.estadoJuego.puntuacionMaxima = puntuacion;
            EstadoJuego.estadoJuego.Guardar();
        }
        //else
        //{
        //    Debug.Log("Record no SUPERADO!!!" + EstadoJuego.estadoJuego.puntuacionMaxima + "Actual" + puntuacion);
        //}
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
}
