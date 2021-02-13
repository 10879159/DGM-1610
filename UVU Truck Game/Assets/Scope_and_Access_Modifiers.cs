using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scope_and_Access_Modifiers : MonoBehaviour
{
    public int alpha = 5;
    
    private AnotherClass myOtherClass;
    
    
    void Start ()
    {
        alpha = 29;
        
        myOtherClass = new AnotherClass();
        myOtherClass.FruitMachine(alpha, myOtherClass.apples);
	Debug.Log("Alpha is set to: " + alpha);
    }
    
    
    void Example (int pens, int crayons)
    {
        int answer;
        answer = pens * crayons * alpha;
        Debug.Log(answer);
    }
}
