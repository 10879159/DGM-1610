using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Variables
    [SerializeField] float horsePower = 20.0f;
    [SerializeField] float turnSpeed = 45.0f;
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody playerRb;

    void Start()
    {
	playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
	// Inputs
	horizontalInput = Input.GetAxis("Horizontal");
	verticalInput = Input.GetAxis("Vertical");
        // Move the vehicle forward.
	playerRb.AddRelativeForce(Vector3.forward * verticalInput * horsePower * Time.deltaTime);
	transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput * verticalInput);
    }
}
