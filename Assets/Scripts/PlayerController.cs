using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;

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
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -10, 10), 0.0f, 0.0f);
    }
}