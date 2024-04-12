using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class SpacePlayerMov : MonoBehaviour
{
    [Header("Movement")]
    public Transform playerPosition;
    public CharacterController controller;
    public float speed = 4f;
    public float sprint = 1.5f;

    [Header("Gravity")]
    public float gravity = -3f * 2f;
    public float jumpHeight = 3f;
    public bool continousJump = true;

    [Header("GroundChecks")]
    public Transform groundCheck;
    public float groundDistance = 0.2f;
    public LayerMask groundMask;
    bool isGrounded;

    Vector3 velocity;
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

        if (Input.GetKey(KeyCode.LeftShift)) //detects for shift key pressed
        {
            controller.Move(move * speed * Time.deltaTime * sprint); //if shift pressed this happens (player moves twice as fast)
            Debug.Log ("Sprinting!");
        } else {
            controller.Move(move * speed * Time.deltaTime); //if shift not is pressed this happens (plyer moves at default speed wich is in the <speed> variable)
        }

        if (continousJump)
        {
            if (Input.GetKey(KeyCode.Space) && isGrounded)
                velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
                //Debug.Log("Jumping!");
        } else {
            if (Input.GetButtonDown("Jump") && isGrounded)
            {
                velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
                //Debug.Log("Jumping!");
            }
        }

        if (Input.GetKey(KeyCode.R))
        {
            Debug.Log("Pressed R!");
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
