using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    [SerializeField] public GameObject Shpere;


    void Start()
    {
        InvokeRepeating("SpawnShpere", 2.0f, 0.5f);
    }

    void SpawnShpere()
    {
        Instantiate(Shpere, transform.position, Quaternion.identity);
    }



}
