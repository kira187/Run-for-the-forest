using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonJugar : MonoBehaviour
{

    public string nombreEscenaParaCargar = "GameScene";

    void OnMouseDown()
    {
        SceneManager.LoadScene(nombreEscenaParaCargar);
        //Camera.main.GetComponent<AudioSource>().Stop();
        //GetComponent<AudioSource>().Play();
        //Invoke("CargarNivelJuego", GetComponent<AudioSource>().clip.length);

    }

    void CargarNivelJuego()
    {
        SceneManager.LoadScene(nombreEscenaParaCargar);
        //SceneManager.loadScene();
    }
}
