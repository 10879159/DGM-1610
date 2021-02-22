using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoke_Repeating : MonoBehaviour
{
    public GameObject target;
    
    
    void Start()
    {
        InvokeRepeating("SpawnObject", 2, 1);
    }
    
    void SpawnObject()
    {
        float x = Random.Range(-6.0f, 6.0f);
        float y = Random.Range(-4.0f, 4.0f);
        Instantiate(target, new Vector3(x, y, 2), Quaternion.identity);
    }
}
