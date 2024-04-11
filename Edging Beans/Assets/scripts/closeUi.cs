using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeUi : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ui;
    bool settingsOpen;

    public void closeBtn()
    {
        ui.SetActive(false);
        
        settingsOpen = true;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    
    void Update()
    {
        if (Input.GetButtonDown("Escape") && settingsOpen) {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            settingsOpen = false;
        }
    }
}
