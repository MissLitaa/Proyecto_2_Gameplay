using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOutofBounds : MonoBehaviour
{
    private float bulletDestroy = 20f;
    private float lowerBound = -5f;

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

        if (transform.position.z < lowerBound)
        {
            //Basta decir este game object sin nombre por que no hay más en el script
            Destroy(gameObject);
        }
    }
}
