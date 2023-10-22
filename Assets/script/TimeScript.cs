using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    private bool isGameOver = false;
    void Start()
    {
        StartTimer();
    }

    void Update()
    {
        if (!isGameOver)
        {
            float elapsedTime = Time.time - startTime;
            UpdateTimerUI(elapsedTime);
        }
    }

    void StartTimer()
    {
        startTime = Time.time;
    }

    void UpdateTimerUI(float elapsedTime)
    {
        // Format time and update UI text
        string minutes = ((int)elapsedTime / 60).ToString("00");
        string seconds = (elapsedTime % 60).ToString("00");
        timerText.text = minutes + ":" + seconds;
    }

    public void EndGame()
    {
        // Call this method when the game ends to stop the timer
        isGameOver = true;
        // You can perform other end-game actions here
    }
}
