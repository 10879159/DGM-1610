using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translation_and_Rotation : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;
    
    
    void Update ()
    {
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime * Input.GetAxis("Vertical"));

	transform.Rotate(Vector3.forward * turnSpeed * Time.deltaTime * -Input.GetAxis("Horizontal"));
    }
}
