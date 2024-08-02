using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnManger : MonoBehaviour
{
    public GameObject obstcals;
    private Vector3 spwanPostion = new Vector3(20f, 0.8f, 0f);
    private PlayerControll playerControllScript;

    void Start()
    {
        playerControllScript = GameObject.Find("Player").GetComponent<PlayerControll>();
        InvokeRepeating("SpawnObstcal", 2f, 2f);
    }

    void SpawnObstcal()
    {
        if (playerControllScript.gameOver == false)
        {
            Instantiate(obstcals, spwanPostion, transform.rotation);
        }

    }

}


