using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarGameOverScreen : MonoBehaviour
{

    public GameObject camaraGameOver;
    
    // Start is called before the first frame update
    void Start()
    {
        NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeHaMuerto");
    }

    void PersonajeHaMuerto(Notification notification)
    {
        camaraGameOver.SetActive(true);
    }
}
