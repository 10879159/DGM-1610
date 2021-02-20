using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look_At : MonoBehaviour
{
    public Transform target;
    
    void Update ()
    {
        transform.LookAt(target);
    }
}