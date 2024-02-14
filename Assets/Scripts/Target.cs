using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Target : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {

        Debug.Log(collision.contacts[0].otherCollider.name);

        if (collision.contacts[0].otherCollider.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
