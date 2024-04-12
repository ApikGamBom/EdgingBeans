using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    int count = 0;

    void Update()
    {
        if (!PauseMenu.isPaused)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                count += 1;
                Debug.Log("Ahhh you shot me" + count + "times!");
            }
        }
    }
}
