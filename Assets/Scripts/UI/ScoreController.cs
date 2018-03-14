using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// NEW USING STATEMENT
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

    private int currentScore;
    private Text scoreText;

	// Use this for initialization
	void Start () {
        currentScore = 0;
        scoreText = GetComponent<Text>();
        // Call function to update UI;
        UpdateText();
	}
	
    // Take care of changing the actual text on the UI
    void UpdateText()
    {
        scoreText.text = "Score: " + currentScore;
    }

    public void UpdateScore(int scoreToAdd)
    {
        currentScore += scoreToAdd;
        UpdateText();
    }
}
