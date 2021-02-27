using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameHasEnded = false;

    public float RestartDelay = 1f;

    public GameObject CompleteLevelUI;
    public GameObject PauseUI;

    public void CompleteLevel()
    {
        CompleteLevelUI.SetActive(true);
    }

    public void Pause()
    {
        PauseUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        PauseUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void EndGame()
    {
        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", RestartDelay);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
