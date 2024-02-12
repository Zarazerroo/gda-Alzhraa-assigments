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
        }
    }

    void SpawnShpere()
    {
        Instantiate(Shpere, transform);
    }


}


