using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var ball = GetComponent<Rigidbody>();

        if (Input.GetKey(KeyCode.Space)) {
            var pos = transform.position;
            pos.y += 0.1f;
            transform.position = pos;
        }
    }
}
