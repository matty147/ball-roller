using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pcamera : MonoBehaviour
{
    //Cursor.visible = false;

    public float speedH = 2.0f;
    public float speedV = 2.0f;
    
    private float yaw = 0.0f;
    private float pitch = 0.0f;

    void Update()
    {
        yaw += speedH * (Input.GetAxis("Horizontal2") + Input.GetAxis("Mouse X") + Input.GetAxis("Horizontal"));
        pitch -= speedV * (Input.GetAxis("Vertical2") + Input.GetAxis("Mouse Y") + Input.GetAxis("Vertical"));
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

    }
}