using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Does any pre-game initialising, such as:
/// Spawning the Game Manager Object with all its scripts,
/// </summary>

public class Initialise : MonoBehaviour
{
    // Reference to the Game Controller Prefab
    public GameObject gameController;

    void Start()
    {
        // Instantiate at position (0, 0, 0) and zero rotation.
        Instantiate(gameController, new Vector3(0, 0, 0), Quaternion.identity);
    }

    private void Update()
    {
        if (GameObject.FindGameObjectWithTag("GameController") != null)
        {
            //SceneManager.LoadScene(sceneName: "02_Introduction");
            SceneManager.LoadScene(sceneName: "03_FrontDesk");
        }
    }
}
