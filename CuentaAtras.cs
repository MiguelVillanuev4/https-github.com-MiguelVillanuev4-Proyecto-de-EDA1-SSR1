using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Codigo basado y modificado de los cursos de domestica
/* sirve para generar la cuantra atras desde los numeros que van bajando desde el tres hasta el 
uno asi como el sonido de la trompeta y la ejecucion del juego*/
public class CuentaAtras : MonoBehaviour
{
    public GameObject motorCalles;
    public GameObject musicaJuego;
    public GameObject sonidoStart;
    public GameObject sonidoMotorCoche;
    public GameObject numeros;
    public Sprite[] numerosIMG;

    public MotorCalles MotorCallesScript;
    public cronometro cronometroScript;

    float tiempoDeEspera = 4;

    public bool pararCuenta = false;
    public bool finContador = false;

    public AudioSource reproductor;
    public AudioClip[] sonidosContador;

    void Start ()
    {
        reproductor = this.gameObject.GetComponent<AudioSource>();
        IniciarCuentaAtras();
    }

    public void IniciarCuentaAtras()
    {
        StartCoroutine(EmpezarCuentaAtras());

    }

    public IEnumerator EmpezarCuentaAtras()
    {

        sonidoStart.GetComponent<AudioSource>().Play();

        yield return new WaitForSeconds(1);

        InvokeRepeating("Contando",1.0f,1.00f);
    }

    void Contando ()
    {
        tiempoDeEspera --;

        if(tiempoDeEspera >= 3)
        {
            numeros.GetComponent<SpriteRenderer>().sprite = numerosIMG[3];
            reproductor.clip = sonidosContador[0];
            reproductor.Play();
        }

        if(tiempoDeEspera <= 3 && tiempoDeEspera >=2)
        {
            numeros.GetComponent<SpriteRenderer>().sprite = numerosIMG[2];
            reproductor.clip = sonidosContador[0];
            reproductor.Play();
        }

        if(tiempoDeEspera <= 2 && tiempoDeEspera >=1)
        {
            numeros.GetComponent<SpriteRenderer>().sprite = numerosIMG[1];
            reproductor.clip = sonidosContador[0];
            reproductor.Play();
        }

        if(tiempoDeEspera <= 1 && finContador == false)
        {
            finContador = true;
            cronometroScript.CronometroEncendido = true;
            MotorCallesScript.cuentaRegresivaT = true;
            numeros.GetComponent<SpriteRenderer>().sprite = numerosIMG[0];
            reproductor.clip = sonidosContador[1];
            reproductor.Play();

            musicaJuego.GetComponent<AudioSource>().Play();
            sonidoMotorCoche.GetComponent<AudioSource>().Play();

        }

        if(tiempoDeEspera <= 0)
        {
            CancelInvoke();
        }

    }
    void Update()
    {
        if(tiempoDeEspera == 0 && pararCuenta == false)
        {
            pararCuenta = true;
            numeros.SetActive(false);
        }
    }
}
