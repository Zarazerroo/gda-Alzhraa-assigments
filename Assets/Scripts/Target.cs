using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Target : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {

        Debug.Log(collision.gameObject);

        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
