using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FollowBallX : MonoBehaviour
{
    public UnityEvent newBall;
    public GameObject spawnManager;
    public SpawnManager spawnManagerScript;

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
        transform.Translate(ballInfo.position.x - transform.position.x, 0, 0);
    }

    public void FindBall()
    {
	ballInfo = GameObject.Find("Ball(Clone)").transform;
	Debug.Log("New Ball! I Follow!");
    }
}
