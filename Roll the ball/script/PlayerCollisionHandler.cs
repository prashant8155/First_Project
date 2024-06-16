using UnityEngine;

public class PlayerCollisionHandler : MonoBehaviour
{
    public GameObject gameOverCanvas; 

    void Start()
    {
        if (gameOverCanvas != null)
        {
            gameOverCanvas.SetActive(false); 
        }
    }

    void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.CompareTag("obstacle"))
        {
            
            if (gameOverCanvas != null)
            {
                gameOverCanvas.SetActive(true);
                
                Time.timeScale = 0f;
            }
        }
    }
}
