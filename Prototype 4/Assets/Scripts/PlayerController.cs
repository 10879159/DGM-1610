using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody PlayerRb;
    private GameObject focalPoint;
    private SpawnManagerScript spawnManager;
    private Vector3 downALittle;

    public float speed = 5.0f;
    public bool hasPowerUp = false;
    public float powerUpStrength = 15.0f;
    public GameObject powerUpIndicator;

    // Start is called before the first frame update
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody>();
	focalPoint = GameObject.Find("FocalPoint");
	spawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManagerScript>();
	downALittle = new Vector3(0, -0.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
	PlayerRb.AddForce(focalPoint.transform.forward * speed * forwardInput);
	powerUpIndicator.transform.position = transform.position + downALittle;
    }

    private void OnTriggerEnter(Collider other) {
	if (other.CompareTag("Powerup")) {
		hasPowerUp = true;
		Destroy(other.gameObject);
		spawnManager.powerUpInPlay = false;
		StartCoroutine(PowerupCountdownRoutine());
		powerUpIndicator.gameObject.SetActive(true);
	}
    }

    IEnumerator PowerupCountdownRoutine() {
	yield return new WaitForSeconds(7);
	hasPowerUp = false;
	powerUpIndicator.gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision) {
	if (collision.gameObject.CompareTag("Enemy") && hasPowerUp) {
		Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
		Vector3 awayFromPlayer = (collision.gameObject.transform.position - transform.position);
		Debug.Log("Collided with " + collision.gameObject.name + " while powerup is " + hasPowerUp);
		enemyRigidbody.AddForce(awayFromPlayer * powerUpStrength, ForceMode.Impulse);
	}
    }
}
