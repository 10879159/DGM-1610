using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBall : MonoBehaviour
{
    private GameObject ball;
    private BallController ballScript;

    // Start is called before the first frame update
    void Start()
    {
	ball = GameObject.Find("Ball");
	ballScript = ball.GetComponent<BallController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.transform.position.x > 51 || ball.transform.position.x < -51) {
		ball.active = false;
	}
	if (Input.GetKeyDown("space") && ball.active == false) {
		ball.active = true;
		ball.transform.Translate(-ball.transform.position.x, 25 - ball.transform.position.y, -ball.transform.position.z);
		ballScript.ballDirection = new Vector3(ballScript.ballXSpeed, Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f));
	}
    }
}
