using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    public TMP_Text resultText;

    void Start()
    {
        // Initially display "--" as the score
        resultText.text = "--";

        // Check if the score is available in PlayerPrefs
        if (PlayerPrefs.HasKey("UserScore"))
        {
            // Retrieve the score from PlayerPrefs
            float userScore = PlayerPrefs.GetFloat("UserScore", 0f);

            // Determine Pass/Fail based on a threshold (e.g., 60%)
            string passFailText = (userScore >= 60f) ? "Pass" : "Fail";

            // Display Pass/Fail in your UI along with the actual score
            resultText.text = passFailText;
        }
    }
}