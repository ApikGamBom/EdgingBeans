using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeUi : MonoBehaviour
{
    public GameObject ui;

    public void closeBtn()
    {
        ui.SetActive(false);
    }

}