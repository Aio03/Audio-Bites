using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionConsistency : MonoBehaviour
{
    /////// This is all useless and to go ///////
    ////// To fix the inconsistency of the dropdown https://answers.unity.com/questions/1260056/how-to-keep-dropdown-values-after-a-scene-switch-o.html //////

    /*

    public string originalSceneLocation;

    private static OptionConsistency OptionConsistencyInstance;

    private void Awake()
    {
        WakeBackUp(originalSceneLocation);

        DontDestroyOnLoad(this);

        if (OptionConsistencyInstance == null)
        {
            OptionConsistencyInstance = this;
        }
        else
        {
            Object.Destroy(gameObject);
        }
    }

    //this doesn't work right now, change it away from using children
    public void WakeBackUp (string scene)
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == scene)
        {
            for (var i = 0; i < transform.childCount; ++i)
            {
                transform.GetChild(i).gameObject.SetActive(true);
            }
        } else
        {
            for (var i = 0; i < transform.childCount; ++i)
            {
                transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }
    */
}
