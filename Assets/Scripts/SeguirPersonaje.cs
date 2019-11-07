using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirPersonaje : MonoBehaviour
{
    public Transform personaje;
    public float separacion = 6.5f;
    
    void Update()
    {
        transform.position = new Vector3(personaje.position.x +separacion, transform.position.y, transform.position.z);    
    }
}
