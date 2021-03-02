using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If_Statements : MonoBehaviour
{
    float Temperature = 85.0f;
    float HotLimit = 70.0f;
    float ColdLimit = 50.0f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
		TemperatureTest();
	Temperature -= Time.deltaTime * 5f;
    }
    
    void TemperatureTest()
    {
	if (Temperature > HotLimit)
	{
		print("Too Hot.");
	}
	else if (Temperature < ColdLimit)
	{
		print("Too Cold.");
	}
	else
	{
		print("Just Right.");
	}
    }
}
