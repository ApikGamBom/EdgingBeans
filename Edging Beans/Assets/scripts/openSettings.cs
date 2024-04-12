using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openSettings : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject canvas;

    [Header("Bools")]
    public bool menuState = true;
    public bool cursorLocked = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            toggleMenu();
        }

        if(cursorLocked)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        } else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        
    }
    public void toggleMenu()
    {
        menuState = !menuState;
        cursorLocked = !cursorLocked;

        if (canvas.activeSelf != menuState)
        {
            canvas.SetActive(menuState);
        }
    }
}
