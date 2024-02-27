using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLiine : MonoBehaviour

{
    [SerializeField] private Vector3 LineStart;
    [SerializeField] private Vector3 LineEnd;
    [SerializeField] private Vector3 RightArowStart;
    [SerializeField] private Vector3 RightArowEnd;
    [SerializeField] private Vector3 LeftArowStart;
    [SerializeField] private Vector3 LeftArowEnd;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(LineStart, LineEnd, Color.red);
        Debug.DrawLine(RightArowStart, RightArowEnd, Color.red);
        Debug.DrawLine(LeftArowStart, LeftArowEnd, Color.red);
    }



}
