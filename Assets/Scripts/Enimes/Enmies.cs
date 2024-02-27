using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enmies : MonoBehaviour
{
    [SerializeField] public Transform spawnPoint;
    [SerializeField] public GameObject shpere;
    [SerializeField] private Rigidbody enmey;

    /// [SerializeField] private Enmiesdata enmiesdata; was for scriptable oject 
    void Awake()
    {
        //StartCoroutine(EnmiesUpDown());

    }
    void Start()
    {
        StartCoroutine(SpawnCoroutine());
        //// I cancel using Invoke because I want to tray coroutines
        ////InvokeRepeating("SpawnShpere", 2.0f, enmiesdata.delayBetweenShooting); 
        //// No need any more since using Singletone
        //// logic = FindObjectOfType<LogicManger>();
        //GameObject.FindGameObjectWithTag("logic").GetComponent<LogicManger>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            LogicManger.Instance.addScore();
        }
    }
    private IEnumerator SpawnCoroutine()
    {
        while (true)
        {
            Instantiate(shpere, spawnPoint.position, Quaternion.identity);
            yield return new WaitForSeconds(6.0f);

        }
    }
    private IEnumerator EnmiesUpDown()
    {
        while (true)
        {
            enmey.velocity = Vector3.up * 5;
            yield return new WaitForSeconds(1.0f);
            enmey.velocity = Vector3.down * 5;
            yield return new WaitForSeconds(1.0f);
        }
    }

    /// void SpawnShpere()
    /// {
    ///     var go = Instantiate(Shpere, transform.position, Quaternion.identity); 
    ///     go.GetComponent<SphereScript>().Init(enmiesdata.bulletSpeed); changed because we wan to use scriptable object but the speed in another script
    ////  }


}
