using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openSettings : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject canvas;
    public bool canvasState;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            toggleCanvas();
        }
        
    }
    public void toggleCanvas()
    {
        canvasState = !canvasState;
        if (canvas.activeSelf != canvasState)
        {
            canvas.SetActive(canvasState);
        }
    }
}
