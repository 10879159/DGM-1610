using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyController : MonoBehaviour
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
	if (GameObject.Find("Ball(Clone)") != null) {
	        transform.Translate(0, ballInfo.position.y - transform.position.y, ballInfo.position.z - transform.position.z);
		if (transform.position.y < 3.5f) {
			transform.Translate(0, 3.5f - transform.position.y, 0);
		} else if (transform.position.y > 46.5f) {
			transform.Translate(0, 46.5f - transform.position.y, 0);
		}
		if (transform.position.z < -21.5f) {
			transform.Translate(0, 0, -21.5f - transform.position.z);
		} else if (transform.position.z > 21.5f) {
			transform.Translate(0, 0, 21.5f - transform.position.z);
		}
		if (transform.position.x != -50) {
			transform.Translate(-50 - transform.position.x, 0, 0);
		}
	}
    }

    public void FindBall()
    {
	ballInfo = GameObject.Find("Ball(Clone)").transform;
	Debug.Log("I see the ball");
    }
}
