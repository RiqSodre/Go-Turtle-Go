using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    public GameObject menu;
    public GameObject pause;
    public GameObject play;
    
    public void PlayGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Stage 1");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Stage 0");
        Time.timeScale = 1;
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        menu.SetActive(true);
        play.SetActive(true);
        pause.SetActive(false);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        menu.SetActive(false);
        play.SetActive(false);
        pause.SetActive(true);
    }
}
