using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Codigo basado y modificado de los cursos de domestica
// En este codigo recae la importancia del juego ya que con ayuda del script MotorCalles este juego posiciona las calles una detras de la otra
public class limiteCarreteras : MonoBehaviour
{
    public MotorCalles motorCallesScript;
/*Aqui se esta utilizando una funcion que se utiliza para que al momento de que un objeto colicione con este mande informacion al codigo 
principal o en este caso con el script MotorCalles ademas se hace el uso de tag para ordenar por capas a los objetos del juego(GameObjects)*/ 
    public void OnTriggerEnter2D ( Collider2D cInfo)
    {
        if(cInfo.gameObject.tag == "limite")
        {
            Destroy(cInfo.transform.parent.gameObject);
            motorCallesScript.CreaCalles();
        }
    }
}
