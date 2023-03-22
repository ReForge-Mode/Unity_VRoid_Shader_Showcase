using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public float cycleDuration = 1.0f; // Duration of one full cycle in seconds
    public float pauseDuration = 0.5f; // Duration of pause before switching to the next color
    public Color[] colors = new Color[] { Color.white, Color.red, Color.green, Color.blue }; // Array of colors to cycle through
    public Light spotlight; // Reference to the spot light component
    private int currentIndex = 0; // Index of the current color in the colors array
    private float cycleTimer = 0.0f; // Timer to track the current position in the cycle
    private bool isPaused = false; // Flag to indicate whether the cycle is currently paused
    private float pauseTimer = 0.0f; // Timer to track the current position in the pause

    private void Update()
    {
        if (!isPaused)
        {
            cycleTimer += Time.deltaTime;
            if (cycleTimer >= cycleDuration)
            {
                cycleTimer -= cycleDuration;
                isPaused = true;
                pauseTimer = 0.0f;
                currentIndex++;
                if (currentIndex >= colors.Length)
                {
                    currentIndex = 0;
                }
            }
        }
        else
        {
            pauseTimer += Time.deltaTime;
            if (pauseTimer >= pauseDuration)
            {
                isPaused = false;
            }
        }
        float t = cycleTimer / cycleDuration;
        Color lerpedColor = Color.Lerp(colors[currentIndex], colors[(currentIndex + 1) % colors.Length], t);
        spotlight.color = lerpedColor;
    }
}
