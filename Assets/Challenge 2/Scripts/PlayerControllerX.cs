using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    
    private float timeElapsed;
    public float dogSpawnInterval = 1;
    
    // Update is called once per frame
    void Update()
    {
        // On spacebar press
        // if time elapsed when spacebar pressed > timeInterval, then send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time - timeElapsed > dogSpawnInterval)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            
            // Change the time space bar pressed to current time
            timeElapsed = Time.time;
        }
    }
}