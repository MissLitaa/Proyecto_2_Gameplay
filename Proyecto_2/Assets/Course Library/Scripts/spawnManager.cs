using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    //Los corchetes estipulan que es un Array [lista].
    //ambitoVisibilidad tipoObjeto[claudatos para lista] nombreObjeto.
    public GameObject[] animalPrefabs;

    public Vector3 spawnPosition;
    public int animalIndex;
    public float randomX;
    private float limX = 15f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", time:2, repeatRate:1.5f);
    }


    public void SpawnRandomAnimal()
    {
        randomX = Random.Range(-limX, limX);
        spawnPosition = new Vector3(randomX, 0, 20);

        //Range(0, numero de elementos que tiene mi array).
        animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);
    }
}
