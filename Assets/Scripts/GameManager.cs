using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public GameObject completeLevelUI;

    // This function makes the End-Game panel visible
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    // This function will be called in PlayerCollision when the game ends
   public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
        }
        Invoke("Restart", 2f);
    }

    // This function will restart the game whenever the game ends
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
