using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayY : MonoBehaviour
{
    public float stayAtY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y != stayAtY) {
		transform.Translate(0, transform.position.y - stayAtY, 0);
	}
    }
}
