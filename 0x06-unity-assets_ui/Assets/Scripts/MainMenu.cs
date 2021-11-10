using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

/// <summary>
/// Main menue
/// </summary>
public class MainMenu : MonoBehaviour
{
    /// <summary>
    /// Method that seleccts level
    /// </summary>
    /// <param name="level">level number</param>
    public void LevelSelect(int level)
    {
        SceneManager.LoadScene(level);
    }

    /// <summary>
    /// Method that enters options menue
    /// </summary>
    public void Options()
    {
        SceneManager.LoadSceneAsync(4);
    }

    /// <summary>
    /// Method that exits game
    /// </summary>
    public void Exit()
    {
        Debug.Log("Exited");
    }

    /// <summary>
    /// Method that save loaded scene
    /// </summary>
    public void SaveLoadedScene()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("previous", currentScene);
    }
}