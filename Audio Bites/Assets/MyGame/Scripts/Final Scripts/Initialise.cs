using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Does any pre-game initialising, such as:
/// Spawning the Game Manager Object with all its scripts,
/// Spawning the Main Camera prefab which has the text hover canvas attached
/// </summary>

public class Initialise : MonoBehaviour
{
    // Reference to the Game Controller Prefab
    public GameObject gameController;
    public GameObject cameraPrefab;
    public GameObject audioVariablesPrefab;

    void Start()
    {
        // Instantiate at position (0, 0, 0) and zero rotation.
        Instantiate(cameraPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        Instantiate(audioVariablesPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        Instantiate(gameController, new Vector3(0, 0, 0), Quaternion.identity);
    }

    private void Update()
    {
        // If the game controller has been instantiated then go to the relevant scene
        if (GameObject.FindGameObjectWithTag("GameController") != null)
        {
            //SceneManager.LoadScene(sceneName: "02_Introduction");
            SceneManager.LoadScene(sceneName: "03_FrontDesk");
        }
    }
}
