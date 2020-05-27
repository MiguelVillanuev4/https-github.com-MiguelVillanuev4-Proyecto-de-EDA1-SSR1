using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Codigo basado y modificado de los cursos de domestica
public class Edificio : MonoBehaviour
{
    public GameObject CronometroGO;
    public cronometro cronometroScript;
//En este codigo se creo la funcion de que cuando chocas con un edificio automaticamante pierdes
    void Start()
    {
        CronometroGO = GameObject.Find("cronometro");
        cronometroScript = CronometroGO.GetComponent<cronometro>();
    }
//Se hace el uso de un oncollisonenter2d para que el coche choque y no solo pase atravez de el
    void OnCollisionEnter2D (Collision2D cInfo)
    {
        if(cInfo.gameObject.tag == "coche")
        {
            cronometroScript.tiempo -=10000000000;
            cronometroScript.ImagenMasTiempo();
            gameObject.SetActive(false);
        }
    }
}
