using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject pauseButton;
    public GameObject QuitBut;
    public PlayerControl pc;
    private void Start()
    {
        pauseMenu.SetActive(false);
    }
    public void PauseWindow()
    {
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
        pauseButton.SetActive(false);
    }

    public void Resume()
    {

        //Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        pauseButton.SetActive(true);
        if (pc.isDead == false)
        {
            Time.timeScale = 1;
        }
    }

    public void Quit()
    {
        //Application.Quit();
        //print("AppClosed");
        SceneManager.LoadScene("Start");

    }
    
}
