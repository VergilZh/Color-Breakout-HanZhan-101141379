using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehaviour : MonoBehaviour
{
    public GameManager GameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoStart()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void GoCredit()
    {
        SceneManager.LoadScene("CreditsScene");
    }

    public void GoMainMeun()
    {
        SceneManager.LoadScene("MainScene");
        Time.timeScale = 1f;
    }

    public void PauseGame()
    {
        GameManager.Pause();
    }

    public void ResumeGame()
    {
        GameManager.Resume();
    }

}
