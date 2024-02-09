using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableGameObject : MonoBehaviour
{
    public GameObject objectToDisable;

    void Start()
    {
        // Disable the specified GameObject at the start of the game
        DisableObject();
    }

    // Call this method to disable the specified GameObject
    public void DisableObject()
    {
        // Check if the GameObject is not null before trying to disable it
        if (objectToDisable != null)
        {
            objectToDisable.SetActive(false);
        }
        else
        {
            Debug.LogError("GameObject to disable is null!");
        }
    }
}