using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("qqqq");
    }

    private void Update()
    {
        bool rest = Input.GetKey(KeyCode.R);

        if(rest == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Time.timeScale = 1;
        }
    }
    public void Reestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
        Time.timeScale = 1f;

        Debug.Log("AAAAAAAAAAAAAAAAAa");
    }
}
