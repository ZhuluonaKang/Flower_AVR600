using UnityEngine;
using UnityEngine.SceneManagement;

public class Flower : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            Playere playerScript = other.GetComponent<Playere>();
            if (playerScript != null)
            {
                int score = playerScript.score;

                // Check if the player has collected 6 bottles
                if (score >= 6)
                {
                    // Load the ending_v scene
                    SceneManager.LoadScene(3);
                }
                else
                {
                    // Load the ending_f scene
                    SceneManager.LoadScene(4);
                }
            }
        }
    }
}