using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Codigo basado y modificado de los cursos de domestica
public class QuitaVidas : MonoBehaviour
{
    public GameObject VidasGO;
    public vidas vidasScript;
//Esta funcion cirve para que todos los objetos que tengan este script no pierdan a los otros gameobjects
    void Start()
    {
        VidasGO = GameObject.Find("vidas");
        vidasScript = VidasGO.GetComponent<vidas>();
    }
    /*Cuando se choca con un objeto esta funcion llama a la funcion de otro script 
    para que puede eliminar la imagen del corazon para mostrar el corazon roto*/
    void OnCollisionEnter2D (Collision2D cInfo)
    {
        if(cInfo.gameObject.tag == "coche")
        {
            vidasScript.contadorVidas = vidasScript.contadorVidas -1;
            vidasScript.ImagenMenosVida();
        }
    }
}
