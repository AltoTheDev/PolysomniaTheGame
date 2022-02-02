using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ThirdPersonMovement : MonoBehaviour
{
    public Vector3 right;
    public Vector3 up;
    public Vector3 front;
    public float speed;


    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += front * speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= front * speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= right * speed;
        }


        if (Input.GetKey(KeyCode.D))
        {
            transform.position += right * speed;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.position -= up * speed;
        }
    }
}
