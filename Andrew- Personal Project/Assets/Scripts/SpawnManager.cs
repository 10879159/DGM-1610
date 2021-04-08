using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpawnManager : MonoBehaviour
{
    public GameObject ballPrefab;
    public UnityEvent newBall;

    // Start is called before the first frame update
    void Start()
    {
	newBall = new UnityEvent();
    }

    // Update is called once per frame
    void Update()
    {
	if (Input.GetKeyDown("space") && GameObject.Find("Ball(Clone)") == null) {
		Instantiate(ballPrefab);
		newBall.Invoke();
	}
    }

    public Transform FindBall()
    {
	return GameObject.Find("Ball(Clone)").transform;
    }
}
