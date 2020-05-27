using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Codigo basado y modificado de los cursos de domestica
public class cronometro : MonoBehaviour
{
    //inicializacion de variables publicas
    public GameObject motorCalles;//tipo GameObject son los objetos de interaccion que se encuentran en el juego
    public MotorCalles MotorCallesScript;//tipo script en estos es necesario de un GameObject para funcionar

    public Text textoTiempo;//Tipo texto este es para registrar datos para despues mostrarselos al usuario
    public Text textoMetros;

    public float distancia;//tipo flotantes sirven para calcular todo lo relacionado con operaciones
    public float tiempo;

    public bool CronometroEncendido; //tipo booleano se utiliza para acer una funcion cierta o no

    public Image masTiempo;//tipo imagen muestran al ususario una imagen ya sea de forma esporadica o permanente
    public Image masDinero;

    public GameObject popfinalGO;
    public POPfinal POPfinalScript;
//en esta primera funcion se le manda al usuario atravez de la interface un texto de cuanto tiempo y distancia lleva 
    void Start()
    {
        textoTiempo.text = "0:00";
        textoMetros.text = "0";
        masTiempo.CrossFadeAlpha(0,0,false);
    }

    //aqui es donde se programa la mecanica principal para llevar el conteo de la distancia y el tiempo
    void Update()
    {
        if (MotorCallesScript.juegoT == false && CronometroEncendido == true)
        {
            distancia += Time.deltaTime * MotorCallesScript.speed;
            textoMetros.text = ((int)distancia).ToString();

            tiempo += Time.deltaTime;
            int minutos = (int)tiempo/60;
            int segundos = (int)tiempo%60;

            textoTiempo.text = minutos.ToString() + ":" + segundos.ToString().PadLeft(2,'0'); 
        }

        if (tiempo <= 0.00f && MotorCallesScript.juegoT == false)
        {
            MotorCallesScript.juegoT = true;
            popfinalGO.SetActive(true);
            POPfinalScript.ActivoGameOver();

        }
    }
//en estas dos funciones sirven para implementar PowerUps los cuales por dificultades tecnicas y de diseño no se introdujeron estos
    public void ImagenMasTiempo()
    {
        masTiempo.CrossFadeAlpha(1,0.5f,false);
        this.gameObject.GetComponent<AudioSource>().Play();
        StartCoroutine(CierroImagenMasTiempo());
    }

    IEnumerator CierroImagenMasTiempo()
    {
        yield return new WaitForSeconds(1);
        masTiempo.CrossFadeAlpha(0,0.5f,false);
    }
}
