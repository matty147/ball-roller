using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GamepadControlls : MonoBehaviour
{

    GamepadControls controls;

    Vector3 move;
    Vector2 rotate;

    void Awake()
    {
        controls = new GamepadControls();

        //controls.Gamepad.Joystickr.performed += ctx => Move();

        controls.Gamepad.Joystickl.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Gamepad.Joystickl.canceled += ctx => move = Vector2.zero;

        controls.Gamepad.Joystickr.performed += ctx => rotate = ctx.ReadValue<Vector2>();
        controls.Gamepad.Joystickr.canceled += ctx => rotate = Vector2.zero;
    }
    void Move()
    {
        
        //transform.localScale *= 1.1f;   
    }

    void Update()
    {
        /*
        Vector3 m = new Vector3(move.x, 0, move.y) * Time.deltaTime * 10;
        transform.Translate(m, Space.World);
        
        Vector2 r = new Vector2(-rotate.y, -rotate.x) * 100f * Time.deltaTime;
        //transform.Rotate(r, Space.World);
       
        
        yaw += speedH * Input.GetAxis("Horizontal");
        pitch -= speedV * Input.GetAxis("Vertical");
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
         */   
    }

    void OnEnable()
    {
        controls.Gamepad.Enable();
    }

    void OnDisabe()
    {
        controls.Gamepad.Disable();
    }
}

