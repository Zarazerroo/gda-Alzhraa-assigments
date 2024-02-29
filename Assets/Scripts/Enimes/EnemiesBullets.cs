using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesBullets : MonoBehaviour
{
    [SerializeField] private float lifeTime;
    [SerializeField] private float speed;
    private Vector3 PlayerDirecation = Vector3.zero;

    private float m_speed;
    void Awake()
    {
        Destroy(gameObject, lifeTime);
    }
    public void Init(float speed)
    {
        m_speed = speed;
    }
    void Update()
    {
        transform.Translate(PlayerDirecation * speed);
    }

    public void SetPlayerDirecation(Vector3 dir)
    {
        PlayerDirecation = dir;
    }
}
