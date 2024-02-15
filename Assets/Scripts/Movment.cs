using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{
    public Rigidbody charcterRigi;
    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            charcterRigi.velocity = Vector3.forward * speed;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            charcterRigi.velocity = Vector3.back * speed;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            charcterRigi.velocity = Vector3.right * speed;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            charcterRigi.velocity = Vector3.left * speed;
        }
    }
}
