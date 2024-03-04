using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enmies : MonoBehaviour
{
    [SerializeField] public Transform spawnPoint;
    [SerializeField] public GameObject shpere;
    [SerializeField] private Rigidbody enmey;

    [SerializeField] private Transform Playertransform;

    [SerializeField] private AudioSource enimesAudioDie;
    private ParticleSystem part;

    private Vector3 PlayerDirecation = Vector3.forward;



    /// [SerializeField] private Enmiesdata enmiesdata; for scriptable object data

    void Start()
    {
        StartCoroutine(SpawnCoroutine());
        part = GetComponent<ParticleSystem>();



        /// //StartCoroutine(EnmiesUpDown()); corotine practice
        /// InvokeRepeating("SpawnShpere", 2.0f, enmiesdata.delayBetweenShooting);
        //// logic = FindObjectOfType<LogicManger>(); //// No need any more since using Singletone 1
        //GameObject.FindGameObjectWithTag("logic").GetComponent<LogicManger>(); //// No need any more since using Singletone 2
    }
    void Update()
    {
        PlayerDirecation = (Playertransform.position - transform.position).normalized;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            enimesAudioDie.Play();
            part.Play();
            Destroy(gameObject, 2.0f);
            LogicManger.Instance.addScore();

        }

    }

    private IEnumerator SpawnCoroutine()
    {
        while (true)
        {

            yield return new WaitForSeconds(2.0f);
            GameObject EnemyBullet = Instantiate(shpere, spawnPoint.position, Quaternion.identity);
            EnemyBullet.GetComponent<EnemiesBullets>().SetPlayerDirecation(PlayerDirecation);
        }
    }
}



// void SpawnShpere()
// {
//        var go = Instantiate(shpere, transform.position, Quaternion.identity);

//    go.GetComponent<EnemiesBullets>().Init(enmiesdata.bulletSpeed); for scriptable object data
// } 

// private IEnumerator EnmiesUpDown()
// {
//    while (true)
//     {
//         enmey.velocity = Vector3.up * 5;
//            yield return new WaitForSeconds(1.0f);   corotine practice
//     enmey.velocity = Vector3.down * 5;
//  yield return new WaitForSeconds(1.0f);
//}
//}