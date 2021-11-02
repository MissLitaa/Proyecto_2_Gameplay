using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public Vector3 spawnPosition = new Vector3(0, 0, 20);
    public int animalIndex;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(animalPrefabs[0], spawnPosition, animalPrefabs[0].transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
