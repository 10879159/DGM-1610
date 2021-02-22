using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket_Destruction : MonoBehaviour
{
    void Start()
    {
        Destroy (gameObject, 1.5f);
    }
}
