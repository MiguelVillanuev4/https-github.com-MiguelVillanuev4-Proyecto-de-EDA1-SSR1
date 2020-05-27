using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Codigo basado y modificado de los cursos de domestica
// Este codigo es la base del juego 
public class MotorCalles : MonoBehaviour
{
    // creacion de variables para el juego
    public GameObject motorCalles;
    public GameObject[] contenedorCalles;

    public float speed;

    public int numSelectorCalle;
    public int contadorCalles = 0;

    public bool cuentaRegresivaT;
    public bool juegoT;
    //funcion start en este caso sirve para llamar a otra funcion e igualar una variable
    void Start()
    {
        juegoT = false;
        InicioJuego();
    }
    //Esta funcion manda llamar a otras dos que estan por debajo de esta para combinar sus propiedades
    public void InicioJuego()
    {
        CreaCalles();
        SpeedCarretera();
        cuentaRegresivaT = false;
    }
    //Funcion update es la de desplasar la carretera en forma decendente al momento de que el juego termine de correr la cuenta regresiva
    void Update()
    {
        if(cuentaRegresivaT && juegoT == false)
        {
            motorCalles.transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }
    //En esta parte del codigo el juego empieza a generar careteras una datras de la otra asiendo que esto se asimile a una pila
    public void CreaCalles()
    {
        numSelectorCalle = Random.Range(0,5);
        GameObject Motor = (GameObject)Instantiate(contenedorCalles[numSelectorCalle],
                                                    new Vector3(-1,500,100),
                                                    transform.rotation);
        Motor.SetActive(true);
        contadorCalles ++;
        Motor.name = "Motor"+contadorCalles;
        Motor.transform.parent = motorCalles.transform;

        GameObject piezaAux = GameObject.Find("Motor"+(contadorCalles-1));
        Motor.transform.position = new Vector3(transform.position.x,
                                                 piezaAux.GetComponent<Renderer>().bounds.size.y + 
                                                 piezaAux.transform.position.y,
                                                 piezaAux.transform.position.z);

    }
    //En todas las funciones siguientes sirven para darle una cierta velocidad a la pista
    public void SpeedStop()
    {
        speed = 0;
    }
    public void SpeedArcen()
    {
        speed = 5;
    }
    public void SpeedCarretera()
    {
        speed = 15;
    }
    public void SpeedCocheMalo1()
    {
        speed = 3;
    }
    public void FinalizarJuego()
    {
        SpeedStop();
    }
}
