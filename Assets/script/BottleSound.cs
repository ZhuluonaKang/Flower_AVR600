using UnityEngine;

public class BottleSound : MonoBehaviour
{
    public AudioClip collisionSound;  // Sound effect file
    private AudioSource audioSource;  // AudioSource component

    void Start()
    {
        // Add AudioSource component to the object
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = collisionSound;
    }

    // Called when the object collides with another object
    void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object has the tag "Player"
        if (collision.gameObject.tag == "Player")
        {
            // Play the collision sound
            PlayCollisionSound();
        }
    }

    // Play the collision sound effect
    void PlayCollisionSound()
    {
        // Check if the sound effect file exists
        if (collisionSound != null)
        {
            // Play the sound effect
            audioSource.Play();
        }
    }
}