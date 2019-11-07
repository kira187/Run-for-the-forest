using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumaPuntoBloque : MonoBehaviour
{
    private bool colisonConJugador = false;
    private int PuntosGanados = 1;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!colisonConJugador && collision.gameObject.tag == "Player")
        {          
            GameObject obj = collision.contacts[0].collider.gameObject;
            if (obj.name == "PataInferiorDerechaB" || obj.name == "PataInferiorIzquierdaB")
            {
                colisonConJugador = true;
                NotificationCenter.DefaultCenter().PostNotification(this, "IncrementarPuntos", PuntosGanados);
            }
        }
    }
}
