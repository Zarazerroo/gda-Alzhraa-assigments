using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawnerEnmies : MonoBehaviour
{
    [SerializeField] public GameObject Shpere;
    [SerializeField] private Enmiesdata enmiesdata;

    void Start()
    {
        InvokeRepeating("SpawnShpere", 2.0f, enmiesdata.delayBetweenShooting);
    }

    void SpawnShpere()
    {
        var go = Instantiate(Shpere, transform.position, Quaternion.identity);
        go.GetComponent<SphereScript>().Init(enmiesdata.bulletSpeed);
    }

}
