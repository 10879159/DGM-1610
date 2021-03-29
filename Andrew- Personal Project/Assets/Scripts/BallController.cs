using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 10.0f;

    private CharacterController ballMover;
    private Vector3 ballDirection;

    // Start is called before the first frame update
    void Start()
    {
        ballMover = GetComponent<CharacterController>();
	ballDirection = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f));
    }

    // Update is called once per frame
    void Update()
    {
        ballMover.Move(ballDirection * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider collidee) {
	if (collidee.gameObject.tag == "verticalBoxPart") {
		ballDirection = new Vector3(ballDirection.x, ballDirection.y, -ballDirection.z);
		Debug.Log("Hit wall!");
	} else if (collidee.gameObject.tag == "horizontalBoxPart") {
		ballDirection = new Vector3(ballDirection.x, -ballDirection.y, ballDirection.z);
	}
    }
}
