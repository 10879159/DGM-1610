using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 10.0f;
    public float angleStrength = 8.0f;
    public float ballXSpeed = 1.0f;

    private CharacterController ballMover;
    private Vector3 ballDirection;

    // Start is called before the first frame update
    void Start()
    {
        ballMover = GetComponent<CharacterController>();
	ballDirection = new Vector3(ballXSpeed, Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f));
    }

    // Update is called once per frame
    void Update()
    {
        ballMover.Move(ballDirection * speed * Time.deltaTime);
	if (transform.position.y < 0.5f) {
		transform.Translate(0, 0.5f - transform.position.y, 0);
	} else if (transform.position.y > 49.5f) {
		transform.Translate(0, 49.5f - transform.position.y, 0);
	}
	if (transform.position.z < -24.5f) {
		transform.Translate(0, 0, -24.5f - transform.position.z);
	} else if (transform.position.z > 24.5f) {
		transform.Translate(0, 0, 24.5f - transform.position.z);
	}
    }

    void OnTriggerEnter(Collider collidee) {
	if (collidee.gameObject.tag == "verticalBoxPart") {
		ballDirection = new Vector3(ballDirection.x, ballDirection.y, -ballDirection.z);
	} else if (collidee.gameObject.tag == "horizontalBoxPart") {
		ballDirection = new Vector3(ballDirection.x, -ballDirection.y, ballDirection.z);
	} else if (collidee.gameObject.tag == "Player") {
		ballDirection = new Vector3(-ballDirection.x, ballDirection.y, ballDirection.z);
	} else if (collidee.gameObject.tag == "Enemy") {
		ballDirection = new Vector3(-ballDirection.x, ballDirection.y, ballDirection.z);
		Debug.Log("Touched Enemy!");
	}
    }
}
