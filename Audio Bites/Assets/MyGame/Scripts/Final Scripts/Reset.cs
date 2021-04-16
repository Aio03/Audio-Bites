using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Deletes any dont destroy on load elements for reset then goes back to the Main Menu scene
/// </summary>
/// 
public class Reset : MonoBehaviour
{

    private GameObject gameController;
    private GameObject mainCamera;
    private GameObject audioVariables;

    private void Awake()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController");
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        audioVariables = GameObject.FindGameObjectWithTag("AudioVariables");
    }

    private void Update()
    {
        if (gameController != null)
        {
            Object.Destroy(gameController);
        }
        if (mainCamera != null)
        {
            Object.Destroy(mainCamera);
        }
        if (audioVariables != null)
        {
            Object.Destroy(audioVariables);
        }

        if (gameController == null && mainCamera == null && audioVariables == null)
        {
            SceneManager.LoadScene(sceneName: "00_MainMenu");
        }

    }

}
