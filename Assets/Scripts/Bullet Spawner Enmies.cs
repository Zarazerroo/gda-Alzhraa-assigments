using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletSpawnerEnmies : MonoBehaviour
{
    [SerializeField] public GameObject Shpere;
    [SerializeField] private Enmiesdata enmiesdata;

    void Start()
    {
        StartCoroutine(SpawnCoroutine());
        //// I cancel using Invoke because I want to tray coroutines
        ////InvokeRepeating("SpawnShpere", 2.0f, enmiesdata.delayBetweenShooting); 
    }

    //// void SpawnShpere()
    /// {
    ///     var go = Instantiate(Shpere, transform.position, Quaternion.identity); 
    ///     go.GetComponent<SphereScript>().Init(enmiesdata.bulletSpeed); changed because we wan to use scriptable object but the speed in another script
    ////  }

    private IEnumerator SpawnCoroutine()
    {
        while (true)
        {
            Instantiate(Shpere, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);

        }
    }
}
