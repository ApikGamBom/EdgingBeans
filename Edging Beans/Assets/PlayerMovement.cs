using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    public Transform playerPosition;
    public CharacterController controller;
    public float speed = 6f;
    public float sprint = 2f;
    public float gravity = -9.81f * 2;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

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

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Pressed R!");
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
