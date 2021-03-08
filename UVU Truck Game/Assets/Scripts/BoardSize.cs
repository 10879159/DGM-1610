using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardSize : MonoBehaviour
{
    public float some_scale_factor = 0.1f;

    private FrontBack BoxSize;

    void Awake()
    {
	BoxSize = GetComponent<FrontBack>();
    }

    // Start is called before the first frame update
    void Start()
    {
	transform.localScale= new Vector3(BoxSize.boxSize * some_scale_factor, BoxSize.boxSize * some_scale_factor, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
