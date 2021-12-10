using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private Vector3 initialPose = Vector3.zero;
    public float playerSpeed = 10f;
    private float horizontalInput;
    private float xRange = 15f;
    public GameObject projectilePrefab;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = initialPose; 
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * playerSpeed * horizontalInput);

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, 0, 0);
        }

        else if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Dispara un proyectil. Instanciar: nombrePrefab, posiciónDelPlayer(por que el script está asignado a player), nombrePrefab.rotaciónPrefabOriginal
            Instantiate(projectilePrefab, transform.position,
                projectilePrefab.transform.rotation);
        }

        
           
    }
}
