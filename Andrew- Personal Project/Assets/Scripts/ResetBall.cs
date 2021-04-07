using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBall : MonoBehaviour
{
    public GameObject ballPrefab;
    public bool newBall = false;

    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(-transform.position.x, 25 - transform.position.y, -transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 51 || transform.position.x < -51) {
		Instantiate(ballPrefab);
		newBall = true;
		Destroy(gameObject);
	}
    }
}
