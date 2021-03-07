using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translation_and_Rotation : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;

    private FrontBack BackFront;
    
    void Awake ()
    {
	BackFront = GetComponent<FrontBack>();
    }

    void Update ()
    {
        if (GetComponent<Renderer>().material.color == Color.red)
	{
		transform.Translate(Vector3.up * moveSpeed * Time.deltaTime * BackFront.frontBack);
		transform.Rotate(Vector3.forward * turnSpeed * Time.deltaTime);
	}

	if (GetComponent<Renderer>().material.color == Color.green)
	{
		transform.Translate(Vector3.up * moveSpeed * Time.deltaTime * BackFront.frontBack);
	}

        if (GetComponent<Renderer>().material.color == Color.blue)
	{
		transform.Translate(Vector3.up * moveSpeed * Time.deltaTime * BackFront.frontBack);
		transform.Rotate(-Vector3.forward * turnSpeed * Time.deltaTime);
	}
    }
}
