using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject player;
    [SerializeField] Vector3 offset = new Vector3(0, 15, -15);

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
