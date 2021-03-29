using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;

    private CharacterController control;
    private Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        control = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
	direction = new Vector3(0, Input.GetAxis("Vertical") * speed * Time.deltaTime, Input.GetAxis("Horizontal") * speed * Time.deltaTime);
        control.Move(direction);
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
	if (transform.position.x != 50) {
		transform.Translate(50 - transform.position.x, 0, 0);
	}
    }
}
