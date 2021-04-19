using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Handles the main buttons that goes on in the Main Menu Scene
/// This includes changing scenes when clicking buttons and closing the program
/// </summary>

public class MainMenu : MonoBehaviour
{

    public GameObject options;
    private bool optionsExist;

    public void Play()
    {
        SceneManager.LoadScene(sceneName: "01_Initialisation");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Options()
    {
        optionsExist = options.transform.GetChild(0).gameObject.activeInHierarchy;
        options.transform.GetChild(0).gameObject.SetActive(!optionsExist);
    }

}
