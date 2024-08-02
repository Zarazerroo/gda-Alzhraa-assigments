using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 8f;
    private PlayerControll playerControllScript;
    private float leftBound = -15;

    void Start()
    {
        playerControllScript = GameObject.Find("Player").GetComponent<PlayerControll>();
    }
    void Update()
    {
        if (playerControllScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstcals"))
        {
            Destroy(gameObject);
        }

    }
}
