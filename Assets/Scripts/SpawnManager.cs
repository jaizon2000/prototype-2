using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int animalIndex;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        GameObject currentAnimal = animalPrefabs[animalIndex];

        if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(currentAnimal, new Vector3(0, 0, 20), currentAnimal.transform.rotation);
        }
    }
}