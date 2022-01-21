using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    /// <summary>
    /// Method that saves loaded scenes
    /// </summary>
    public void SaveLoadedScene()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("previous", currentScene);
    }

    /// <summary>
    /// Method that turn back to the previous loaded scene
    /// </summary>
    public void Back()
    {
        //int previousLoadedScene = MainMenu.GetLoadedScene();
        //SceneManager.LoadSceneAsync(previousLoadedScene);

        int previousScene = PlayerPrefs.GetInt("previous",0);
        SceneManager.LoadSceneAsync(previousScene);
    }
}
