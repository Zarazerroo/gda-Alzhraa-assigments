using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCubeMathf : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Mathf.Sin(Time.time), 0, Mathf.Cos(Time.time));

    }
}
