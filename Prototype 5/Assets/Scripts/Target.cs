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

    private Rigidbody targetRb;

    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
	targetRb.AddForce(RandomForce(), ForceMode.Impulse);
	targetRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);
	transform.position = RandomSpawnPos();
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

    // Update is called once per frame
    void Update()
    {
	
    }
}
