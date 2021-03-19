using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private float dying = 0f;
    private float dieCounter = 0f;
    public float deathSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
	
    }

    // Update is called once per frame
    void Update()
    {
	if (dying == 1) {
		dieCounter += 1;
		transform.Rotate(Vector3.forward * deathSpeed * Time.deltaTime);
	}
	if (dieCounter == 30) {
		Destroy(gameObject);
	}
    }

    void OnTriggerEnter(Collider other) {
	Destroy(other.gameObject);
	dying = 1;
    }
}
