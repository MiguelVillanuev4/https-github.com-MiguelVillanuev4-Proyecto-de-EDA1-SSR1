using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Codigo basado y modificado de un video de youtube
//en este codigo se programo la dinamica de cambio de escenas a travez de los botones del teclado E y R
public class Cambio : MonoBehaviour
{
//se utiliza la funcion update para implementar los botones de trancicion
    void Update()
    {
        if(Input.GetKeyDown (KeyCode.E)) SceneManager.LoadScene (1);
        if(Input.GetKeyDown (KeyCode.R)) SceneManager.LoadScene (0);
    }
}
