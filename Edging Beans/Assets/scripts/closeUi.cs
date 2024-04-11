using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeUi : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ui;
    public bool settingsOpen;
    public openSettings openSettingsScript;

    public void closeBtn()
    {
        ui.SetActive(false);
        
        settingsOpen = true;

        openSettingsScript.cursorLocked = true;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}