using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{


    [SerializeField] private float lifeTime;
    [SerializeField] private float speed;

    /// private float m_speed; this was for the scriptable object look in the Bullet Spawner Enmies script
    void Awake()
    {
        Destroy(gameObject, lifeTime);
    }

    //public void Init(float speed) for scrpitable object
    /// {
    //     m_speed = speed;
    // }

    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
