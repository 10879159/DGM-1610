using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class Teleport_Away : MonoBehaviour
{
    public BoxCollider collisioner;

    private FrontBack BoxSize;

    // Start is called before the first frame update
    void Awake ()
    {
        BoxSize = GetComponent<FrontBack>();
	collisioner = collisioner.GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
	transform.position = new Vector3(Random.Range(-BoxSize.boxSize, BoxSize.boxSize), Random.Range(-BoxSize.boxSize, BoxSize.boxSize), 0);
    }
}
