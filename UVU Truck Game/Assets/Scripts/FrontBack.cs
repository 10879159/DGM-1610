using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontBack : MonoBehaviour
{
	public float frontBack = 1f;
	public float boxSize = 4f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > boxSize)
	{
		frontBack = -frontBack;
		transform.position = new Vector3(transform.position.x, boxSize, 0);
	}
	else if (transform.position.y < -boxSize)
	{
		frontBack = -frontBack;
		transform.position = new Vector3(transform.position.x, -boxSize, 0);
	}
	else if (transform.position.x > boxSize)
	{
		frontBack = -frontBack;
		transform.position = new Vector3(boxSize, transform.position.y, 0);
	}
	else if (transform.position.x < -boxSize)
	{
		frontBack = -frontBack;
		transform.position = new Vector3(-boxSize, transform.position.y, 0);
	}
    }
}
