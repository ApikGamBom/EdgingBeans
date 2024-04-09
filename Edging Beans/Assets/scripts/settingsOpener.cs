using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject settingsTab;
    public string tagToCheck = "normBtn";
    public GameObject settingsTabinTab;
    public void load()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void CheckChildrenForTag()
    {
        settingsTab.SetActive(!settingsTab.activeSelf);
        if (!settingsTab.activeSelf)
        {
            settingsTab.SetActive(false);
        }


            
        foreach (Transform child in transform)
        {
            if (child.CompareTag(tagToCheck))
            {
                Debug.Log(child.name + " has the tag " + tagToCheck);
                child.gameObject.SetActive(!child.gameObject.activeSelf);
            }
            else
            {
                Debug.Log("No " + tagToCheck + " found.");
            }
        }
    }
}