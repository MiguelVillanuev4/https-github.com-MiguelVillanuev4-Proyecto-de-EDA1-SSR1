using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Codigo basado y modificado de los cursos de domestica
public class Fundido : MonoBehaviour
{
    public Image imagenFundido;
//codigo que funciona para que una imagen se difumine marcando el cambio de una escena con la otra
    void Start()
    {
       imagenFundido.CrossFadeAlpha(0,0.5f,false); 
    }

}
