using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{


    [SerializeField] public float lifeTime;
    private float m_speed;

    void Awake()
    {
        Destroy(gameObject, lifeTime);

    }

    public void Init(float speed)
    {
        m_speed = speed;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(m_speed * Time.deltaTime, 0, 0);
    }
}
