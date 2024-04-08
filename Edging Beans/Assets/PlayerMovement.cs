using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 6f;
    public float sprint = 2f;
    public float gravity = -9.81f * 2;

    Vector3 velocity;
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        if (Input.GetKey (KeyCode.LeftShift)) //detects for shift key pressed
        {
            controller.Move(move * speed * Time.deltaTime * sprint); //if shift pressed this happens (player moves twice as fast)
            //Debug.Log ("Sprinting!");
        } else {
            controller.Move(move * speed * Time.deltaTime); //if shift not is pressed this happens (plyer moves at default speed wich is 3)
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
