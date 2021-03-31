using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerScript : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject powerUpPrefab;
    public float spawnRate = 1.0f;
    public bool powerUpInPlay = false;

    private float spawnRange = 9.0f;
    private PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
	playerController = GameObject.Find("Player").GetComponent<PlayerController>();
	InvokeRepeating("SpawnEnemy", 2.0f, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy() {
	Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
	if (!powerUpInPlay && !playerController.hasPowerUp) {
		Instantiate(powerUpPrefab, GenerateSpawnPosition(), powerUpPrefab.transform.rotation);
		powerUpInPlay = true;
		Debug.Log("Powerup spawned!");
	}
    }

    private Vector3 GenerateSpawnPosition() {
	float spawnPosX = Random.Range(-spawnRange, spawnRange);
	float spawnPosZ = Random.Range(-spawnRange, spawnRange);
	Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
	return randomPos;
    }
}
