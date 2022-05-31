using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10f;
    private float turnSpeed = 25f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the bus forward and backward
        forwardInput = Input.GetAxis("Vertical");
        speed = forwardInput < 0 ? 5f : 10f;
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        
        // Turn the bus. When going backward, turn the other direction.
        horizontalInput = Input.GetAxis("Horizontal");
        if (forwardInput < 0) {
            horizontalInput = -horizontalInput;
        }
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
