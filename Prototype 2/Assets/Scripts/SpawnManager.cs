using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int animalIndex;
    private Vector3 animalSpawnLocation;

    // Start is called before the first frame update
    void Start()
    {
        animalSpawnLocation = new Vector3(0, 0, 20);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)) {
		Instantiate(animalPrefabs[animalIndex], animalSpawnLocation, animalPrefabs[animalIndex].transform.rotation);
	}
    }
}
