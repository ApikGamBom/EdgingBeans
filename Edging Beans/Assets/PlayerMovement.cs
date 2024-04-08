using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 6f;
    public float sprint = 2f;
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        if (Input.GetKey (KeyCode.LeftShift))
        {
            controller.Move(move * speed * Time.deltaTime * sprint);
            //Debug.Log ("Sprinting!");
        } else {
            controller.Move(move * speed * Time.deltaTime);
        }
    }
}
