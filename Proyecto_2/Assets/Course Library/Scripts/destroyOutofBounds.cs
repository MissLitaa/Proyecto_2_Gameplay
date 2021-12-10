using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOutofBounds : MonoBehaviour
{
    private float bulletDestroy = 20f;
    private float lowerBound = -5f;
    private GameObject player;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Bullet destroy.

        if (transform.position.z > bulletDestroy)
        {
            //Basta decir este game object sin nombre por que no hay más en el script
            Destroy(gameObject);
        }

        //Destruir animales.

        if (transform.position.z < lowerBound)
        {
            //Basta decir este game object sin nombre por que no hay más en el script
            //El orden es necesario, encontrar player, destruir player, destroy animal, GAMEOVER, para el juego.
            player = GameObject.Find("Player");
            Destroy(player);
            Destroy(gameObject);
            Debug.Log("GAME OVER");
            Time.timeScale = 0;
            
        }
    }
}
