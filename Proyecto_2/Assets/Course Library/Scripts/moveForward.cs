using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveForward : MonoBehaviour
{
    public float moveSpeed = 40f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //translaci�n : movimiento del objeto, posici�n= posici�n al empezar
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);

        
    }

}
