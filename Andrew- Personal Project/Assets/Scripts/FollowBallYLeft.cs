using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FollowBallYLeft : MonoBehaviour
{
    public UnityEvent newBall;

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
        transform.Translate(ballInfo.position.y - transform.position.y, 0, 0);
    }

    public void FindBall()
    {
        ballInfo = GameObject.Find("Ball").transform;
    }
}
