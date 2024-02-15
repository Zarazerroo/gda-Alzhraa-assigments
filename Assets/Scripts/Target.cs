using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Target : MonoBehaviour
{
    public LogicManger logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicManger>();
    }

    void OnCollisionEnter(Collision collision)
    {



        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            logic.addScore();
        }
    }
}
