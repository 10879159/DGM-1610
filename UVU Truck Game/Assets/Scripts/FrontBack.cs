using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontBack : MonoBehaviour
{
	public float frontBack = 1f;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 5)
	{
		frontBack = -frontBack;
	}
	else if (transform.position.y < -5)
	{
		frontBack = -frontBack;
	}
	else if (transform.position.x > 5)
	{
		frontBack = -frontBack;
	}
	else if (transform.position.x < -5)
	{
		frontBack = -frontBack;
	}
    }
}
