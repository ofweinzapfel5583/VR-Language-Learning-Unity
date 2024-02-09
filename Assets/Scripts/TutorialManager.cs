using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialManager : MonoBehaviour
{
    public GameObject tutorialCanvas;

    public void ContinueToCafeScene()
    {
        Debug.Log("calling?");
        //You don't want to do this. Instead you want to set the tutorial to not active.
        SceneManager.LoadScene("CafeScene");
    }

    public void GoBackToMainScene()
    {
        Debug.Log("or you?");
        SceneManager.LoadScene("MainScene");
    }
}