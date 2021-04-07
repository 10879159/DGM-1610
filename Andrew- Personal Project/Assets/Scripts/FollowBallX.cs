using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBallX : MonoBehaviour
{
    private Transform ballInfo;
    public ResetBall newBallScript;

    // Start is called before the first frame update
    void Start()
    {
        ballInfo = GameObject.Find("Ball").transform;
	newBallScript = GameObject.Find("Ball").GetComponent<ResetBall>();
    }

    // Update is called once per frame
    void Update()
    {
	if (newBallScript.newBall) {
		ballInfo = GameObject.Find("Ball").transform;
		newBallScript = GameObject.Find("Ball").GetComponent<ResetBall>();
		newBallScript.newBall = false;
	}
        transform.Translate(ballInfo.position.x - transform.position.x, 0, 0);
    }
}
