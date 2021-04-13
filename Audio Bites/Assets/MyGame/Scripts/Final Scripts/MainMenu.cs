using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Handles everything that goes on in the Main Menu Scene
/// This includes changing scenes when clicking buttons and closing the program
/// </summary>

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(sceneName: "01_Initialisation");
    }

    public void Exit()
    {
        Application.Quit();
    }

}
