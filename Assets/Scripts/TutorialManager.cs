using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialManager : MonoBehaviour
{
    public GameObject tutorialCanvas;

    public void ContinueToCafeScene()
    {
        SceneManager.LoadScene("CafeScene");
    }

    public void GoBackToMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}