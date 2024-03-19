using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TutorialManager : MonoBehaviour
{
    public GameObject tutorialCanvas;

    public void ContinueToCafeScene()
    {
        Debug.Log("Calling cafe scene");
        // Close the tutorial canvas before loading the cafe scene
        tutorialCanvas.SetActive(false);
    }

    public void GoBackToMainScene()
    {
        Debug.Log("Calling main scene");
        SceneManager.LoadScene("Main Scene");
    }

    public void GoBackToCafeScene()
    {
        Debug.Log("Calling cafe scene");
        SceneManager.LoadScene("Cafe Scene");
    }

    public void GoBackToCafeScene1()
    {
        Debug.Log("Calling cafe scene 1");
        SceneManager.LoadScene("Cafe Scene 1");
    }
}