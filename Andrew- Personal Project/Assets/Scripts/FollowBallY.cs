using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBallY : MonoBehaviour
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
        transform.Translate(transform.position.y - ballInfo.position.y, 0, 0);
    }
}
