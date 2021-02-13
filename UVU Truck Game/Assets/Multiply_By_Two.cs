using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multiply_By_Two : MonoBehaviour
{
    // Start is called before the first frame update
	void Start()
	{
		int MyInt = 7;
		Debug.Log(MyInt);
		MyInt = MultiplyByTwo(MyInt);
		Debug.Log(MyInt);
	}

	int MultiplyByTwo(int number)
	{
		int result = number * 2;
		return result;
	}
}
