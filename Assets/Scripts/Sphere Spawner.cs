using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SphereSpawner : MonoBehaviour
{

    [SerializeField] public GameObject Shpere;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnShpere();
            InvokeRepeating("SpawnShpere", 0.0f, 1.0f);

        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            CancelInvoke();
        }

    }

    void SpawnShpere()
    {
        Instantiate(Shpere, transform.position, Quaternion.identity);
    }



}


