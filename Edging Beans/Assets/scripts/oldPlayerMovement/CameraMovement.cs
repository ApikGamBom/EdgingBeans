//using System;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class CameraMovement : MonoBehaviour
//{

//  public float mouseSensetivity = 100f;
//  public Transform playerBody;
//  float xRotation = 0f;
//  public bool alwCamMovement = true;

//  void Start()
//{
//  Cursor.lockState = CursorLockMode.Locked;
//    }

//  void Update()
//{
//  if (alwCamMovement)
//{
//float MouseX = Input.GetAxis("MouseX") * mouseSensetivity * 4 * Time.deltaTime;
//float MouseY = Input.GetAxis("MouseY") * mouseSensetivity * 4 * Time.deltaTime;

//xRotation -= MouseY;
//xRotation = Mathf.Clamp(xRotation, -90f, 90f);

//transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
//playerBody.Rotate(Vector3.up * MouseX);
//        };
//    }
//}
