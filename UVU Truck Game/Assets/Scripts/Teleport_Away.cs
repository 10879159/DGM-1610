using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class Teleport_Away : MonoBehaviour
{
    public BoxCollider collisioner;

    // Start is called before the first frame update
    void Awake ()
    {
        collisioner = collisioner.GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
	transform.position = new Vector3(Random.Range(-4, 4), Random.Range(-4, 4), 0);
    }
}
