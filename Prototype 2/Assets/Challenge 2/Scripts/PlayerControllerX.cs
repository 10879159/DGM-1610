using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private int dogYes = 1;
    private int dogCounter = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (dogYes == 1)
	    {
		Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
		dogYes = 0;
	    }
	}
	if (dogYes == 0)
	{
	    dogCounter += 1;
	    if (dogCounter == 25) 
	    {
		dogYes = 1;
		dogCounter = 0;
	    }
	}
    }
}
