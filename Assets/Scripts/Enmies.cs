using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enmies : MonoBehaviour
{
    public LogicManger logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = FindObjectOfType<LogicManger>();
        //GameObject.FindGameObjectWithTag("logic").GetComponent<LogicManger>();
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
