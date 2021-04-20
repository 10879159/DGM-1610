using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Transform ballInfo;

    // Start is called before the first frame update
    void Start()
    {
	ballInfo = GameObject.Find("Ball").transform;
    }

    // Update is called once per frame
    void Update()
    {
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
