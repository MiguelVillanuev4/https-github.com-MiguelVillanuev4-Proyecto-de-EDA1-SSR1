using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Codigo basado y modificado de los cursos de domestica
public class POPfinal : MonoBehaviour
{

    public Image BGpop;
    public Image imgPOP;
    public Button botonReiniciar;
    public Text metrosRecorridos;
    public GameObject popfinalGO;
    public Image imagenFundido;
    public cronometro cronometroScript;
    public GameObject musicaJuego;
    public AudioClip musicaGameOver;
    public GameObject Cochesito;

    // Start is called before the first frame update
    void Start()
    {
        popfinalGO.SetActive(false);
    }
//En esta parte se activa y se desactiva la interface de la pantalla de GameOver
    public void ActivoGameOver()
    {
        musicaJuego.GetComponent<AudioSource>().clip = musicaGameOver;
        musicaJuego.GetComponent<AudioSource>().Play();
        botonReiniciar.gameObject.SetActive(true);
        BGpop.CrossFadeAlpha(1,0.3f,false);
        imgPOP.CrossFadeAlpha(1,0.3f,false);
        metrosRecorridos.CrossFadeAlpha(1,0.3f,false);
        metrosRecorridos.text = "SCORE:  " + ((int)cronometroScript.distancia).ToString() + "  MTS";
        Cochesito.GetComponent<AudioSource>().Stop();

    }
    /*aqui se implementa el uso de un boton el cual te dirige a la pantalla del menu principal
pero por problemas con los botones de la interface se descarto esta parte del codigo*/
    public void ReiniciarJuego()
    {
        imagenFundido.CrossFadeAlpha(1,0.5f,false);
        StartCoroutine(CargoEscena());
    }

    IEnumerator CargoEscena()
    {
        yield return new WaitForSeconds(1);
        Application.LoadLevel("Intro");
    }
}
