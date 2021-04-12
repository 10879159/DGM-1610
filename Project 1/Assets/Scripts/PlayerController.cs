using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Variables
    [SerializeField] float speed = 20.0f;
    [SerializeField] float turnSpeed = 45.0f;
    private float horizontalInput;
    private float verticalInput;

    // Update is called once per frame
    void Update()
    {
	// Inputs
	horizontalInput = Input.GetAxis("Horizontal");
	verticalInput = Input.GetAxis("Vertical");
        // Move the vehicle forward.
	transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
	transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput * verticalInput);
    }
}
