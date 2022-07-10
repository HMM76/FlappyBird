using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject startb;
    public GameObject Quitb;
    public GameObject open;

    public void Open()
    {
        startb.SetActive(true);
        Quitb.SetActive(true);
    }
    public void start()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
        Debug.Log("SceneOpened");
    }

    public void Quit()
    {
        Application.Quit();
        print("QuitCompleted");
    }
}
