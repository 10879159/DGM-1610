using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    private Vector3 animalSpawnLocation;
    private float spawnRangeX = 10.0f;
    private float spawnZ = 20.0f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnZ);
	if (Input.GetKeyDown(KeyCode.S)) {
		int animalIndex = Random.Range(0, animalPrefabs.Length);
		Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
	}
    }
}
