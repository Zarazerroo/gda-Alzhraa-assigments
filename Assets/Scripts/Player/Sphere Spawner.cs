using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SphereSpawner : MonoBehaviour
{
    [SerializeField] public GameObject Shpere;
    [SerializeField] public Transform spawnPoint;
    private Animator animator;

    void Start()
    {
        // Get the Animator component
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //SpawnShpere();
            //InvokeRepeating("SpawnShpere", 0.0f, 1.0f);
            animator.SetBool("shoot", true);

        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetBool("shoot", false);
            ///CancelInvoke();
        }
    }
    void SpawnShpere()
    {
        var go = Instantiate(Shpere, transform.position, Quaternion.identity);
        /// go.GetComponent<SphereScript>().Init(10);
    }
    public void ShootNow()
    {
        SpawnShpere();
    }
}


