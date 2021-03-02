using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int counter = 0;
	while (counter < 10)
	{
		print(counter);
		counter++;
	}

	do
	{
		print(counter);
		counter--;
	}
	while (counter > 0);

	for(int i = 5; i > counter; i--)
	{
		print(counter);
	}
    }
}
