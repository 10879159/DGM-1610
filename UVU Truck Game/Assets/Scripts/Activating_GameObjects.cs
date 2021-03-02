using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activating_GameObjects : MonoBehaviour
{
    public GameObject myObject;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
	Debug.Log("Active Self: " + myObject.activeSelf);
        Debug.Log("Active in Hierarchy" + myObject.activeInHierarchy);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
