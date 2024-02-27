using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{
    public Rigidbody charcterRigi;
    private float speed = 10.0f;

    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hitData;

        if (Physics.Raycast(ray, out hitData))
        {
            // Debug.Log(hitData);

            Debug.DrawLine(ray.origin, ray.direction, Color.blue);
        }
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            charcterRigi.velocity = Vector3.forward * speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            charcterRigi.velocity = Vector3.back * speed;
        }

        if (Input.GetKey(KeyCode.W))
        {
            charcterRigi.velocity = Vector3.right * speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            charcterRigi.velocity = Vector3.left * speed;
        }

    }



}

