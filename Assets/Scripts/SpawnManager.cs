using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    // X/Z of animal spawn
    private float spawnRangeX = 20;
    private float spawnRangeZ = 20;

    // Time of spawn of animals
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        // Call SpawnRandomAnimal() starting at startDelay and repeat every spawnInterval
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        GameObject currentAnimal = animalPrefabs[animalIndex];
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);
        Instantiate(currentAnimal, spawnPos, currentAnimal.transform.rotation);
    }
}