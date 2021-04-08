using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FollowBallX : MonoBehaviour
{
    private UnityEvent newBall;

    private Transform ballInfo;

    // Start is called before the first frame update
    void Start()
    {
	newBall = GameObject.Find("SpawnManager").GetComponent<SpawnManager>().newBall;
	newBall.AddListener(FindBall);
    }

    // Update is called once per frame
    void Update()
    {
	if (ballInfo != null) {
		transform.Translate(ballInfo.position.x - transform.position.x, 0, 0);
	}
	//Debug.Log(ballInfo.position.x);
	Debug.Log("blerp");
    }

    public void FindBall()
    {
	ballInfo = GameObject.Find("Ball(Clone)").transform;
	Debug.Log("I see the line");
    }
}
