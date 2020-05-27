using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Codigo basado y modificado de los cursos de domestica
public class CocheMalo1 : MonoBehaviour
{
    public GameObject motorCalles;
   public MotorCalles MotorCallesScript;
   public GameObject cochesito;

     void Start()
    {
        motorCalles = GameObject.Find("MotorCalles");
        MotorCallesScript = motorCalles.GetComponent<MotorCalles>();
        cochesito = GameObject.Find("Cochesito");
    }
//Programa utilizado para las coliciones con el coche protagonista
   void OnCollisionEnter2D(Collision2D cInfo)
   {
       if(cInfo.gameObject.tag == "coche")
       {
           MotorCallesScript.SpeedCocheMalo1();
           cochesito.GetComponent<AudioSource>().pitch = 1f;
           this.gameObject.GetComponent<AudioSource>().Play();
       }
        
   }

   void OnCollisionExit2D(Collision2D cInfo)
   {
      if(cInfo.gameObject.tag == "cochesito")
       {
           MotorCallesScript.SpeedCarretera();
           cochesito.GetComponent<AudioSource>().pitch = 1.6f;
       } 
   }
}
