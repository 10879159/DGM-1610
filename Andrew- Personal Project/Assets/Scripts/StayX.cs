using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayX : MonoBehaviour
{
    public float stayAtX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x != stayAtX) {
		transform.Translate(transform.position.x - stayAtX, 0, 0);
	}
    }
}
