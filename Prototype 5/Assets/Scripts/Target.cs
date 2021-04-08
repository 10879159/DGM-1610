using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float minSpeed = 15f;
    public float maxSpeed = 19f;
    public float maxTorque = 10f;
    public float xRange = 4f;
    public float ySpawnPos = -6f;
    public int pointValue;
    public ParticleSystem explosion;

    private Rigidbody targetRb;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
	targetRb.AddForce(RandomForce(), ForceMode.Impulse);
	targetRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);
	transform.position = RandomSpawnPos();
	gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public Vector3 RandomForce()
    {
	return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }

    public float RandomTorque()
    {
	return Random.Range(-maxTorque, maxTorque);
    }

    public Vector3 RandomSpawnPos()
    {
	return new Vector3(Random.Range(-xRange, xRange), ySpawnPos);
    }

    private void OnMouseDown()
    {
	if (!gameManager.gameOver) {
		gameManager.UpdateScore(pointValue);
		Instantiate(explosion, transform.position, explosion.transform.rotation);
		gameManager.totalPopCount++;
		if (gameObject.CompareTag("Bad") && gameManager.canGameOver) {
			gameManager.GameOver();
		}
		Destroy(gameObject);
	}
    }

    private void OnTriggerEnter(Collider other)
    {
	if (!gameObject.CompareTag("Bad") && gameManager.canGameOver) {
		gameManager.GameOver();
	}
	Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
	
    }
}
