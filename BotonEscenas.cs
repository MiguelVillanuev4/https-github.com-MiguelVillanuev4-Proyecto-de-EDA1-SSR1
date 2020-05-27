using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Codigo basado y modificado de los cursos de domestica
public class BotonEscenas : MonoBehaviour
{
    public Image fundido;
    // las siguentes cuatro funciones sirven para que el boton del menu principal tenga diferentes propiedades como cambio de color hasta el cambio de escena
    void OnMouseDown()
    {
        this.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.3f,0.3f,0.3f,1);
        this.gameObject.GetComponent<AudioSource>().Play();

    }

    void OnMouseOver()
    {
        this.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.5f,0.5f,0.5f,1);

    }
    void OnMouseExit()
    {
        this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1,1,1,1);

    }
    void OnMouseUp()
    {
        this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1,1,1,1);
        this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
        fundido.CrossFadeAlpha(1,0.5f,false);
        StartCoroutine(CargoEscena());
    }
//sirve para desaparecer o aparecer imagenes, objetos y escenas en cuestion
    IEnumerator CargoEscena()
    {
        yield return new WaitForSeconds (1);
        Application.LoadLevel("SSR1");
    }
}
