using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 10.0f;

    private Rigidbody enemyRb;
    private GameObject player;
    private GameOver gameOverScript;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
	player = GameObject.Find("Player");
	gameOverScript = player.GetComponent<GameOver>();
    }

    // Update is called once per frame
    void Update()
    {
	if (!gameOverScript.gameOver) {
		Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        	enemyRb.AddForce(lookDirection * speed);
	}
    }
}
