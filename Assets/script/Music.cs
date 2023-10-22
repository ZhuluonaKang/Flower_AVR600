using UnityEngine;


public class Music : MonoBehaviour
{
    // Reference to the Audio Source component
    private AudioSource audioSource;

    void Start()
    {
        // Get the Audio Source component
        audioSource = GetComponent<AudioSource>();

        // Play the background music
        audioSource.Play();
    }
}

