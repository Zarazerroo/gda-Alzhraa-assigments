using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMathf : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 1.0f;
    [SerializeField] private float distanceFromCenter = 2.0f;
    [SerializeField] Vector3 rotationAxies = Vector3.up;
    [SerializeField] Vector3 initialPosition;

    private void Start()
    {
        // store the initial postion of the cube
        initialPosition = transform.position;
    }
    private void Update()
    {
        /// the old code I did
        ///transform.Translate(Mathf.Sin(Time.time) , 0, Mathf.Cos(Time.time) );
        ///
        ///calculate the angle cased on time and rotation speed
        float angle = Time.time * rotationSpeed;
        /// Calculate the new postion of the cube using sine and cosine function
        float x = initialPosition.x + Mathf.Cos(angle) * distanceFromCenter;
        float z = initialPosition.z + Mathf.Sin(angle) * distanceFromCenter;
        //set the new postion of the cube
        transform.position = new Vector3(x, initialPosition.y, z);
        // rotate the cube around the initial postion
        transform.RotateAround(initialPosition, rotationAxies, rotationSpeed * Time.deltaTime);

    }
}
