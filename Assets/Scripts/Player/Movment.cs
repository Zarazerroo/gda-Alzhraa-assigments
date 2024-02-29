using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{
    private Animator animator;
    private bool isMoving = false;
    public Rigidbody charcterRigi;
    private float speed = 10.0f;

    void Start()
    {
        // Get the Animator component
        animator = GetComponent<Animator>();
    }

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

        if (Input.GetKey(KeyCode.A) && !isMoving)
        {
            //isMoving = true;
            charcterRigi.velocity = Vector3.forward * speed;
            animator.SetBool("isMoving", true);
            transform.rotation = Quaternion.LookRotation(charcterRigi.velocity);
        }

        else if (Input.GetKey(KeyCode.D) && !isMoving)
        {
            //isMoving = true;
            charcterRigi.velocity = Vector3.back * speed;
            animator.SetBool("isMoving", true);
            transform.rotation = Quaternion.LookRotation(charcterRigi.velocity);
        }

        else if (Input.GetKey(KeyCode.W) && !isMoving)
        {
            //isMoving = true;
            charcterRigi.velocity = Vector3.right * speed;
            animator.SetBool("isMoving", true);
            transform.rotation = Quaternion.LookRotation(charcterRigi.velocity);
        }

        else if (Input.GetKey(KeyCode.S) && !isMoving)
        {
            // isMoving = true;
            charcterRigi.velocity = Vector3.left * speed;
            animator.SetBool("isMoving", true);
            transform.rotation = Quaternion.LookRotation(charcterRigi.velocity);
        }

        else //if (!Input.GetKey(KeyCode.S) || !Input.GetKey(KeyCode.W) || !Input.GetKey(KeyCode.D) || !Input.GetKey(KeyCode.A))
        {
            //isMoving = false;
            charcterRigi.velocity = Vector3.zero * speed;
            animator.SetBool("isMoving", false);
        }


    }


}

