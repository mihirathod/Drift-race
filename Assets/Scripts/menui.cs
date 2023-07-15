using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menui : MonoBehaviour
{
    public bool GoTimer;
    public void ONPlaY()
    {
        Time.timeScale = 1;
    }
    public void ONPause()
    {
        Time.timeScale = 0;
    }
    public void Race1Scene()
    {
        SceneManager.LoadScene("Race1");
    }
    public void PoolScene()
    {
        SceneManager.LoadScene("pool");
    }
    public void HomeScreen()
    {
        SceneManager.LoadScene("HomeScreen");
    }
    public void ONExit()
    {
        Application.Quit();
    }
}
