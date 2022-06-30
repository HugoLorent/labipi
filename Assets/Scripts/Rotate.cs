using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    float speed = 50.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /* if (Input.GetKey(KeyCode.UpArrow))
        {
            // transform.Translate(Vector3.forward * Time.deltaTime * speed);
            transform.RotateAround(Vector3.up, speed);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
        }*/

        float rotX = Input.GetAxis("Mouse X")* speed * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y")* speed * Mathf.Deg2Rad;

        transform.RotateAround(Vector3.back, -rotX / speed);
        transform.RotateAround(Vector3.right, rotY / speed);

        Debug.LogWarning(rotY);
    }
}
