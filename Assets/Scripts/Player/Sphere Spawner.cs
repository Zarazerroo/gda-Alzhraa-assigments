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
    private Movment playerMovement;

    void Start()
    {
        // Get the Animator component
        animator = GetComponent<Animator>();
        playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<Movment>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("shoot", true);
            //////SpawnShpere(); this was for the invoke
            //InvokeRepeating("SpawnShpere", 0.0f, 1.0f); this was for the invoke
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetBool("shoot", false);
            ///CancelInvoke();  this was for the invoke
        }
    }
    void SpawnShpere()
    {
        Instantiate(Shpere, spawnPoint.position, Quaternion.LookRotation(playerMovement.transform.forward));

    }
    public void ShootNow()
    {
        SpawnShpere();
    }
}


