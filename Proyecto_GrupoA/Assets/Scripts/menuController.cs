using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuController : MonoBehaviour
{

    [SerializeField]
    GameObject pauseButton;

    [SerializeField]
    GameObject pauseOptions;

    public void playLevel(int level)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(level);
    }

    public void exitGame()
    {
        Time.timeScale = 1f;
        Application.Quit();
    }

    public void pauseGame()
    {
        pauseButton.SetActive(false);
        pauseOptions.SetActive(true);
        Time.timeScale = 0f;
    }

    public void resumeGame()
    {
        pauseButton.SetActive(true);
        pauseOptions.SetActive(false);
        Time.timeScale = 1f;
    }
}
