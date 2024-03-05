using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollw : MonoBehaviour
{
    [SerializeField] public Transform playerPostion;
    void Update()
    {
        GetComponent<NavMeshAgent>().destination = playerPostion.position;

    }
}