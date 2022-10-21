using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    public float sensX;
    public float sensY;

    public Transform orientation;

    float xRotation;
    float yRotation;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = input.GetAxisRaw('Mouse X') * Time.deltaTime * sensX;
        float mouseY = input.GetAxisRaw('Mouse Y') * Time.deltaTime * sensY;

        yRotation += mouseX;
        xRotation -= mouseY;

    }
}
