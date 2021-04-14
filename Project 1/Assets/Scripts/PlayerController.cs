using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    // Variables
    [SerializeField] float horsePower = 20.0f;
    [SerializeField] float turnSpeed = 45.0f;
    [SerializeField] GameObject centerOfMass;
    [SerializeField] TextMeshProUGUI speedometerText;
    [SerializeField] TextMeshProUGUI rpmText;
    [SerializeField] float rpm;
    [SerializeField] float speed;
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody playerRb;

    [SerializeField] List<WheelCollider> allWheels;
    [SerializeField] int wheelsOnGround;

    void Start()
    {
	playerRb = GetComponent<Rigidbody>();
	playerRb.centerOfMass = centerOfMass.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
	if (IsOnGround()) {
		// Inputs
		horizontalInput = Input.GetAxis("Horizontal");
		verticalInput = Input.GetAxis("Vertical");
        	// Move the vehicle forward.
		playerRb.AddRelativeForce(Vector3.forward * verticalInput * horsePower * Time.deltaTime);
		transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput * verticalInput);
		speed = Mathf.Round(playerRb.velocity.magnitude * 2.237f);
		rpm = Mathf.Round((speed % 30) * 40);
		speedometerText.SetText("Speed: " + speed + " mph");
		rpmText.SetText("RPM: " + rpm);
	}
    }

    bool IsOnGround()
    {
	wheelsOnGround = 0;
	foreach (WheelCollider wheel in allWheels) {
		if (wheel.isGrounded) {
			wheelsOnGround++;
		}
	}
	if (wheelsOnGround == 4) {
		return true;
	} else {
		return false;
	}
    }
}
