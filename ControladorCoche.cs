using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Codigo basado y modificado de los cursos de domestica
public class ControladorCoche : MonoBehaviour
{
    public GameObject coche;
    public float velocidadMovimientoCoche;

    //float factor = 3; sentencia que se iba a nececitar en el caso de multiplicarse alguna sentencia por 3
    public float anguloDeGiro;
    //En esta parte de la codificacion se implemento el giro del coche para que pueda moverse de izquierda a derecha
    void FixedUpdate()
    {
        float giroEnEjeZ = 0;
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal")* velocidadMovimientoCoche* Time.deltaTime);
        giroEnEjeZ = Input.GetAxis("Horizontal")* -anguloDeGiro;
        coche.transform.rotation = Quaternion.Euler(0,0,giroEnEjeZ);

        if (coche.transform.position.y < -4.3f || coche.transform.position.x < -10.0f || coche.transform.position.x >10)
        {
            ResetPosition();
        }

    }
//ademas de que se le agrega la propiedad de respawnear el coche en el centro despues de colicionar con un objeto del escenario
    void ResetPosition ()
    {
        coche.transform.position = new Vector3(0f,-2.4f,0f);
    }
}
