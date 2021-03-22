using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 10f;
    public float gravityModifier;
    public bool isOnGround = true;

    private Rigidbody PlayerRB;

    // Start is called before the first frame update
    void Start()
    {
        PlayerRB = GetComponent<Rigidbody>();
	Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround) {
		PlayerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
		isOnGround = false;
	}
    }

    private void OnCollisionEnter(Collision collision)
    {
	isOnGround = true;
    }
}
