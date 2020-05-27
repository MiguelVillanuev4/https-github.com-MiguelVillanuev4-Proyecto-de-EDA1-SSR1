using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Codigo basado y modificado de los cursos de domestica
public class BorrarPreferencias : MonoBehaviour
{
    //borra las preferencias que tenga unity ante algunos GameObjects o scripts entre otras funcionalidades de Unity
    void Awake()
    {
        PlayerPrefs.DeleteAll();
    }

    
}
