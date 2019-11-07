using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonJugar : MonoBehaviour
{

    public string nombreEscenaParaCargar = "GameScene";

    void OnMouseDown()
    {
        Application.LoadLevel(nombreEscenaParaCargar);
        //Camera.main.GetComponent<AudioSource>().Stop();
        //GetComponent<AudioSource>().Play();
        //Invoke("CargarNivelJuego", GetComponent<AudioSource>().clip.length);

    }

    void CargarNivelJuego()
    {
        Application.LoadLevel(nombreEscenaParaCargar);
        //SceneManager.loadScene();
    }
}
