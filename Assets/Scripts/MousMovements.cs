using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousMovements : MonoBehaviour
{
    public float mousSensitivity = 500f;

    float xRotation = 0f;
    float yRotation = 0f;

    public float topClamp = -90f;
    public float bottomClamp = 90f;


    void Start()
    {
        //Locking the cursor to the middle of the screen and make it invisible
        Cursor.lockState = CursorLockMode.Locked;
    }

    
    void Update()
    {
        //Getting the mouse inputs
        float mouseX = Input.GetAxis("Mouse X") * mousSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mousSensitivity * Time.deltaTime;

        //Rotation around the x axis (Look up and down)
        xRotation -= mouseY;
        
        //clamp the rotation
        xRotation= Mathf.Clamp(xRotation, topClamp, bottomClamp);

        //Rotation around the Y axis (Look left and right)
        yRotation += mouseX;

        //Apply rotations to our transform
        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);


        
    }
}
