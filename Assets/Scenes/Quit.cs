using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    // Method to quit the game
    public void QuitGame()
    {
        // Quit the game when running in the editor
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            // Quit the game in a build
            Application.Quit();
#endif     
    }
}
