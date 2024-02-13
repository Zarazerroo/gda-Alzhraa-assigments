using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    [SerializeField] public float lifeTime;
    [SerializeField] public float Speed;
    void Awake()
    {

        Destroy(gameObject, lifeTime);

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Speed * Time.deltaTime, 0, 0);
    }
}
