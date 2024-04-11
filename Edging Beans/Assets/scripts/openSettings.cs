using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openSettings : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject canvas;

    [Header("Bools")]
    public bool canvasState;
    public bool cursorLocked = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            toggleCanvas();
        }
        
    }
    public void toggleCanvas()
    {
        canvasState = !canvasState;
        cursorLocked = !cursorLocked;

        if (canvas.activeSelf != canvasState)
        {
            canvas.SetActive(canvasState);
        }

        if (cursorLocked)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
