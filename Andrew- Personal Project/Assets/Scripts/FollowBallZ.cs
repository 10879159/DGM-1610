using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FollowBallZ : MonoBehaviour
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
        transform.Translate(transform.position.z - ballInfo.position.z, 0, 0);
    }

    public void FindBall()
    {
        ballInfo = GameObject.Find("Ball").transform;
    }
}
