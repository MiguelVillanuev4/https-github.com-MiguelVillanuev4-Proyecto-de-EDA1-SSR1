using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Codigo basado y modificado de los cursos de domestica
public class vidas : MonoBehaviour
{
    public GameObject[] Vidas;
    public int contadorVidas = 3;
    public GameObject popfinalGO;
    public POPfinal popfinalScript;
    public GameObject motorCalles;
    public MotorCalles MotorCallesScript;
    public cronometro cronometroScript;
    public Image menosVida;

    void Start()
    {
        menosVida.CrossFadeAlpha(0,0,false);
    }
//en esta parte del codigo se utiliza para todos los posibles casos en los que el coche colicione con un obstaculo
    void Update()
    {
        if (contadorVidas == 2 && MotorCallesScript.juegoT == false)
        {
            Vidas[2].SetActive(false);
        }
        if(contadorVidas == 1)
        {
            Vidas[1].SetActive(false);
        }
        if(contadorVidas == 0 && MotorCallesScript.juegoT == false)
        {
            Vidas[0].SetActive(false);
            MotorCallesScript.juegoT = true;
            cronometroScript.CronometroEncendido = false;
            popfinalGO.SetActive(true);
            popfinalScript.ActivoGameOver();
        }
    }
    //es la funcion que se encarga de desaparecer del juego la imagen del corazon esta es invocada en el script QuitaVidas
    public void ImagenMenosVida()
    {
        if(contadorVidas >= 1)
        {
            menosVida.CrossFadeAlpha(1,0.5f,false);
            this.gameObject.GetComponent<AudioSource>().Play ();
            StartCoroutine(CierroImagenMenosVida());
        }
    }

    IEnumerator CierroImagenMenosVida()
    {
        yield return new WaitForSeconds(1);
        menosVida.CrossFadeAlpha(0,0.5f,false);

    }
}
