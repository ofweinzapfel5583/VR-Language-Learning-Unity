using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EvaluationScript : MonoBehaviour
{
    public TMP_Text englishSentenceText;
    public string WhisperOutputToBeEvaluated;
    public TMP_Text resultText;
    public TMP_Text correctTranslationText;

    private string correctTranslation;

    private void Start()
    {
        // Set the English sentence and its correct German translation
        englishSentenceText.text = "Hello, how are you?";
        correctTranslation = "Hallo, wie ghet es?";
    }

    public void CheckAnswer(string WhisperOutputToBeEvaluated)
    {
        string userAnswer = WhisperOutputToBeEvaluated;
        float similarityPercentage = CalculateSimilarityPercentage(correctTranslation, userAnswer);
        Debug.Log("Similarity Percentage: " + similarityPercentage);

        if (similarityPercentage > 60f)
        {
            resultText.text = "Pass";
        }
        else
        {
            resultText.text = "Fail";
        }

        correctTranslationText.text = "Correct Translation: " + correctTranslation;
    }

    private float CalculateSimilarityPercentage(string str1, string str2)
    {
        int maxLength = Mathf.Max(str1.Length, str2.Length);
        int commonCharacters = 0;

        for (int i = 0; i < maxLength; i++)
        {
            if (i < str1.Length && i < str2.Length && str1[i] == str2[i])
            {
                commonCharacters++;
            }
        }

        float similarityPercentage = (float)commonCharacters / maxLength * 100f;
        return similarityPercentage;
    }
}
