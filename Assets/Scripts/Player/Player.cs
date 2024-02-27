using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Material m_normalMaterial;
    [SerializeField] private Material m_hitMaterial;

    void Awake()
    {
        m_normalMaterial = gameObject.GetComponent<MeshRenderer>().sharedMaterial;
    }

    void OnCollisionEnter(Collision collision)
    {

        /// Debug.Log(collision.gameObject);

        if (collision.gameObject.tag == "Shootable")
        {
            HitColor();
            Invoke("DefaultColor", 0.8f);

        }
    }

    void HitColor()
    {
        gameObject.GetComponent<MeshRenderer>().sharedMaterial = m_hitMaterial;
    }

    void DefaultColor()
    {
        gameObject.GetComponent<MeshRenderer>().sharedMaterial = m_normalMaterial;
    }
}
// public void SetColor("Player",(199,24,24,255))



