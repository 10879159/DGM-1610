using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translation_and_Rotation : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;
    private int frontBack = 1;
    
    
    void Update ()
    {
        if (GetComponent<Renderer>().material.color == Color.red)
	{
		transform.Translate(Vector3.up * moveSpeed * Time.deltaTime * frontBack);
		transform.Rotate(Vector3.forward * turnSpeed * Time.deltaTime);
	}

	if (GetComponent<Renderer>().material.color == Color.green)
	{
		transform.Translate(Vector3.up * moveSpeed * Time.deltaTime * frontBack);
	}

        if (GetComponent<Renderer>().material.color == Color.blue)
	{
		transform.Translate(Vector3.up * moveSpeed * Time.deltaTime * frontBack);
		transform.Rotate(-Vector3.forward * turnSpeed * Time.deltaTime);
	}
    }
}
