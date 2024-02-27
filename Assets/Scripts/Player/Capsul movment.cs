using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsulmovment : MonoBehaviour
{
  public Rigidbody charcterRigi;
  public float speed = 10.0f;
  void Awake()
  {
    charcterRigi = GetComponent<Rigidbody>();
  }



  void FixedUpdate()
  {
    if (Input.GetKey(KeyCode.UpArrow))
    {
      charcterRigi.velocity = Vector3.forward;
    }

    if (Input.GetKey(KeyCode.DownArrow))
    {
      charcterRigi.velocity = Vector3.back;
    }

    if (Input.GetKey(KeyCode.RightArrow))
    {
      charcterRigi.velocity = Vector3.right;
    }

    if (Input.GetKey(KeyCode.LeftArrow))
    {
      charcterRigi.velocity = Vector3.left;
    }

  }



}
