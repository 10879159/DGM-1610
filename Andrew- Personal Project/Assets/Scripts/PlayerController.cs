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
    }
}
