using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText;

    public static bool isPlaying = true;
    public static float ObsVelocity = 0.2f;
    public static float BGVelocity = 0.01f;
    public static int Score = 0;

    private float timer = 0f; // Timer to keep track of time

    private void Start()
    {
        // Set initial score text
        UpdateScoreText();
    }

    private void Update()
    {
        if (isPlaying)
        {
            // Increment timer
            timer += Time.deltaTime;

            // Check if one second has passed
            if (timer >= 1f)
            {
                // Increment score by 1 for every second
                Score++;
                UpdateScoreText(); // Update score text
                timer = 0f; // Reset timer
            }

            // Update velocities
            ObsVelocity += 0.008f * Time.deltaTime;
            BGVelocity += 0.0005f * Time.deltaTime;
        }
    }

    // Function to update the score text
    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            // Display the current score
            scoreText.text = "" + Score;
        }
        else
        {
            Debug.LogWarning("scoreText is not assigned in the GameManager script.");
        }
    }
}
