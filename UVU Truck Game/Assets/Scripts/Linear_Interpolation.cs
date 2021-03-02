using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linear_Interpolation : MonoBehaviour
{

    float garbage = 0f;

    // Update is called once per frame
    void Update()
    {
	if (Input.GetKeyDown(KeyCode.Space)) {
        	garbage = Mathf.Lerp (garbage, 20f, 0.5f);
		print(garbage);
	}
    }
}
