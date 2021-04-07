using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBallYLeft : MonoBehaviour
{
    private Transform ballInfo;


    // Start is called before the first frame update
    void Start()
    {
        ballInfo = GameObject.Find("Ball").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(ballInfo.position.y - transform.position.y, 0, 0);
    }
}
