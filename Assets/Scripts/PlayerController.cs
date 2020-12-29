using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 15.0f;

    public GameObject projectilePrefab;

    private int outOfBoundRange = 20;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * (Time.deltaTime * horizontalInput * speed));

        // Makes it so that it's only visible in a given range
        // Mathf.Clamp: https://docs.unity3d.com/ScriptReference/Mathf.Clamp.html
        transform.position =
            new Vector3(Mathf.Clamp(transform.position.x, -outOfBoundRange, outOfBoundRange), 0.0f, 0.0f);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from player   

            // Instantiate - lets you copy a prefab
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}