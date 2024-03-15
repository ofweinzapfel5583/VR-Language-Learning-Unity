using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine;

public class CompletionManager : MonoBehaviour
{
    public GameObject completionModal;
    private int specialObjectsCollected = 0;
    private int totalSpecialObjects = 3; // Change this value to match the number of special objects

    private void Start()
    {
        // Find all XRGrabInteractable components in the scene
        XRGrabInteractable[] grabInteractables = FindObjectsOfType<XRGrabInteractable>();

        // Subscribe to grab events for all XRGrabInteractable components
        foreach (XRGrabInteractable grabInteractable in grabInteractables)
        {
            grabInteractable.onSelectEntered.AddListener(OnObjectGrabbed);
        }
    }

    private void OnObjectGrabbed(XRBaseInteractor interactor)
    {
        GameObject grabbedObject = interactor.selectTarget.gameObject;

        // Check if the grabbed object is tagged as a special object
        if (grabbedObject.CompareTag("SpecialObject"))
        {
            Debug.Log("Special object grabbed: " + grabbedObject.name);

            // Increase the count of collected special objects
            specialObjectsCollected++;
            Debug.Log("Special objects collected: " + specialObjectsCollected);

            // Check if all special objects have been collected
            if (specialObjectsCollected >= totalSpecialObjects)
            {
                // Show the completion modal
                Debug.Log("All special objects collected. Showing completion modal.");
                completionModal.SetActive(true);
            }
        }
    }
}