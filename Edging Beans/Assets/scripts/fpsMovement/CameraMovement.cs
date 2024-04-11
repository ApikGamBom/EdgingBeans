using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [Header("Bools")]
    public bool alwCamMovement = true;
    public bool pauseMenuOpen = false;

    public float mouseSensetivity = 200f;
    public Transform playerBody;
    float xRotation = 0f;

  void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

  void Update()
    {
        if(Input.GetButtonDown("Cancel") && alwCamMovement)
        {
            pauseMenuOpen = true;
            //Debug.Log("Set to true");
        } else if(Input.GetButtonDown("Cancel")) {
            pauseMenuOpen = false;
            //Debug.Log("Set to false");
        }

        if(pauseMenuOpen) {
            alwCamMovement = false;
        } else {
            alwCamMovement = true;
        }

        if(alwCamMovement)
        {
            float MouseX = Input.GetAxis("MouseX") * mouseSensetivity * 4 * Time.deltaTime;
            float MouseY = Input.GetAxis("MouseY") * mouseSensetivity * 4 * Time.deltaTime;

            xRotation -= MouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            playerBody.Rotate(Vector3.up * MouseX);
        }
    }
}
