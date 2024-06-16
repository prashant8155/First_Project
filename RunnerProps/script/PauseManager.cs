using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public GameObject pauseMenuCanvas; 
    // Assign this in the Inspector

    private bool isPaused = false;

    // Method to toggle pause and unpause the game
    public void TogglePause()
    {
        if (isPaused)
        {
            ResumeGame();
        }
        else
        {
            PauseGame();
        }
    }

    // Method to pause the game
    public void PauseGame()
    {
        Time.timeScale = 0f; // Pause the game
        isPaused = true;
        pauseMenuCanvas.SetActive(true);

       
    }

    // Method to resume the game
    public void ResumeGame()
    {
        Time.timeScale = 1f; // Resume the game
        isPaused = false;
        pauseMenuCanvas.SetActive(false);
        
    }
}
