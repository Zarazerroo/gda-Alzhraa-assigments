using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{

    [SerializeField] private float lifeTime;
    [SerializeField] private float speed;

    void Awake()
    {
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        transform.Translate(transform.forward * speed * Time.deltaTime);//speed * Time.deltaTime, 0, 0);
    }
}
