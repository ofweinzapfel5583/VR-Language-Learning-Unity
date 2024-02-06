using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;

public class GrabAndShowInfo : MonoBehaviour
{
    public GameObject infoPanel;
    public AudioClip audioClip;

    private XRGrabInteractable grabInteractable;
    private ObjectAudioHandler audioHandler;

    private void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        audioHandler = GetComponent<ObjectAudioHandler>();

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

        //Play audio clip
        if (audioHandler != null)
        {
            audioHandler.PlayAudio();
        }
    }

    private void OnRelease(XRBaseInteractor interactor)
    {
        // Hide UI panel
        infoPanel.SetActive(false);
    }
}
