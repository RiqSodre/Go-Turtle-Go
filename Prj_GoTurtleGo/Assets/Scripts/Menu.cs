using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    public GameObject menu;
    public GameObject pause;
    public GameObject play;
    
    public void LoadScene(string cena)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(cena);
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void GoToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        menu.SetActive(true);
        play.SetActive(true);
        pause.SetActive(false);
        Musicplayer ms = new Musicplayer();
        ms.audioSource.Stop();
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        menu.SetActive(false);
        play.SetActive(false);
        pause.SetActive(true);
        Musicplayer ms = new Musicplayer();
        ms.audioSource.Play();
    }
}
