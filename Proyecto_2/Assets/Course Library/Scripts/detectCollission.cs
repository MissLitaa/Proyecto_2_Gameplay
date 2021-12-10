using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectCollission : MonoBehaviour
{
    //El primer collider es el proyectil. OtherTrigger es el animal.
    private void OnTriggerEnter(Collider otherTrigger)
    {
        //Destruyo el othertrigger, que es un animal.
        Destroy(otherTrigger.gameObject);
        //Destroy gameobject del proyectil por que no hay nada especificado, ergo es sí mismo.
        Destroy(gameObject);
    }
}
