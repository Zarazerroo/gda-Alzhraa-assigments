using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] public Transform Player;
    float cameraOffset;
    private Vector3 initialPosition;
    private Vector3 cameraRotation;

    private void Start()
    {
        initialPosition = transform.position;
        cameraOffset = Vector3.Distance(initialPosition, Player.position);
        cameraRotation = transform.rotation.eulerAngles;
    }
    private void Update()
    {

        float mouseX = Input.GetAxis("Mouse X");
        if (mouseX != 0)
        {
            cameraRotation.y += mouseX;
        }
        transform.eulerAngles = cameraRotation;
        Vector3 cameraLookDirection = Quaternion.Euler(cameraRotation) * Vector3.forward;
        transform.position = -cameraLookDirection * cameraOffset + Player.position;

    }

    void OnEnable()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void OnDisable()
    {
        Cursor.lockState = CursorLockMode.None;
    }

}
