using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLocation : MonoBehaviour
{
    public static MouseLocation Instance;
    [HideInInspector] public Vector3 MousePosition; //Location in 3D space of the mouse cursor	
    [HideInInspector] public bool IsValid;          //Is the mouse location valid?

    [SerializeField] LayerMask whatIsGround;        //A LayerMask indicating what is considered to be ground when determining the mouse's location

    Ray mouseRay;                                   //A ray that will be used to find the mouse
    RaycastHit hit;                                 //A RaycastHit which will store information about a raycast
    Vector2 screenPosition;							//Where the mouse is on the screen
    void Awake()
    {
        //singletone//This is a common approach to handling a class with a reference to itself.
        //If instance variable doesn't exist, assign this object to it
        if (Instance == null)
            Instance = this;
        //Otherwise, if the instance variable does exist, but it isn't this object, destroy this object.
        //This is useful so that we cannot have more than one MouseLocation object in a scene at a time.
        else if (Instance != this)
            Destroy(this);
    }

    // Update is called once per frame
    void Update()
    {
        IsValid = false;
        screenPosition = Input.mousePosition;
        //Create a ray that extends from the main camera, through the mouse's position on the screen
        //into the scene
        mouseRay = Camera.main.ScreenPointToRay(screenPosition);
        //If the ray from our camera hits something that is ground...
        if (Physics.Raycast(mouseRay, out hit, 100f, whatIsGround))
        {
            //...the mouse position is valid...
            IsValid = true;
            //...and record the point in 3D space that the ray hit the ground
            MousePosition = hit.point;
        }

    }

    public void UpdatePosition(Vector2 position)
    {
        screenPosition = position;
    }
}
