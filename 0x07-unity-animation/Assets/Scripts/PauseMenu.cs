using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// Class for pause menue
/// </summary>
public class PauseMenu : MonoBehaviour
{

    public bool pauseGame;
    private void Start()
    {
        pauseGame = false;
        this.GetComponent<Canvas>().enabled = false;
    }
    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (pauseGame)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }


    /// <summary>
    /// Pause: Function that pauses the game
    /// </summary>
    public void Pause()
    {
        pauseGame = true;
        Time.timeScale = 0;
        this.GetComponent<Canvas>().enabled = true;
    }

    /// <summary>
    /// Function that resumes game after pause
    /// </summary>
    public void Resume()
    {
        pauseGame = false;
        Time.timeScale = 1;
        this.GetComponent<Canvas>().enabled = false;
    }

    /// <summary>
    /// Restrat game
    /// </summary>
    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
    }
    
    /// <summary>
    /// Switch to main menue
    /// </summary>
    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    /// <summary>
    /// Switch to options menue
    /// </summary>
    public void Options()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Options");
    }
}
