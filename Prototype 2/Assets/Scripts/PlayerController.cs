using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;
    public GameObject projectilePrefab;

    private Vector3 leftBound;
    private Vector3 rightBound;

    // Start is called before the first frame update
    void Start()
    {
	leftBound = new Vector3(-xRange, transform.position.y, transform.position.z);
	rightBound = new Vector3(xRange, transform.position.y, transform.position.z);        
    }

    // Update is called once per frame
    void Update()
    {
	// Keep player in bounds
	if (transform.position.x < -xRange) {
		transform.position = leftBound;
	}
	if (transform.position.x > xRange) {
		transform.position = rightBound;
	}
	// Move player based on input
        horizontalInput = Input.GetAxis("Horizontal");
	transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
	// Get Space Input
	if (Input.GetKeyDown(KeyCode.Space)) {
		// Launch Projectile
		Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
	}
    }
}
