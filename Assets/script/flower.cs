using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class flower : MonoBehaviour
{
    // Called when another collider enters this object's collider in Unity
    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider is the player
        if (other.CompareTag("Player"))
        {
            // Player collided with the flower, load the game over scene
            SceneManager.LoadScene(2);
        }

    }
}
