using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class panle : MonoBehaviour
{
    private void Awake()
    {
        Time.timeScale = .001f;
        
    }
    public void start()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }
    public void restart()
    {
        gameObject.SetActive(false);
        SceneManager.LoadScene(0);
    }
    public void exit()
    {
        Application.Quit();
    }
}
