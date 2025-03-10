using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody body;
    [SerializeField] float waitTime = 3f;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;
        body = GetComponent<Rigidbody>();
        body.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > waitTime)
        {
            renderer.enabled = true;
            body.useGravity = true;
        }
    }
}
