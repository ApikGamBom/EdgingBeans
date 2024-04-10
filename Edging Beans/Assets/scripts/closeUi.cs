using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeUi : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ui;
    public void closeBtn()
    {
        ui.SetActive(false);
    }
}
