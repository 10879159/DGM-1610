using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody PlayerRb;
    private GameObject focalPoint;

    public float speed = 5.0f;
    public bool hasPowerUp = false;

    // Start is called before the first frame update
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody>();
	focalPoint = GameObject.Find("FocalPoint");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
	PlayerRb.AddForce(focalPoint.transform.forward * speed * forwardInput);
    }

    private void OnTriggerEnter(Collider other) {
	if (other.CompareTag("Powerup")) {
		hasPowerUp = true;
		Destroy(other.gameObject);
	}
    }

    private void OnCollisionEnter(Collision collision) {
	if (collision.gameObject.CompareTag("Enemy") && hasPowerUp) {
		Debug.Log("Collided with " + collision.gameObject.name + " while powerup is " + hasPowerUp);
	}
    }
}
