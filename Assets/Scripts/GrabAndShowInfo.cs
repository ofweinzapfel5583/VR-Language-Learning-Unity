using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;

public class GrabAndShowInfo : MonoBehaviour
{
    public GameObject infoPanel;

    private XRGrabInteractable grabInteractable;

    private void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();

        // Subscribe to grab and release events
        grabInteractable.onSelectEntered.AddListener(OnGrab);
        grabInteractable.onSelectExited.AddListener(OnRelease);

        // Disable the info panel initially
        infoPanel.SetActive(false);
    }

    private void OnGrab(XRBaseInteractor interactor)
    {
        // Show UI panel and update content
        infoPanel.SetActive(true);
        // Add logic to update UI content based on the grabbed object
    }

    private void OnRelease(XRBaseInteractor interactor)
    {
        // Hide UI panel
        infoPanel.SetActive(false);
    }
}
