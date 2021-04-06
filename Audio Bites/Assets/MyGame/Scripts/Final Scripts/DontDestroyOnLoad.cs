using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A simple script for setting something to be consistent across scenes
/// </summary>

public class DontDestroyOnLoad : MonoBehaviour
{
    private static DontDestroyOnLoad ControllerInstance;
    private void Awake()
    {
        //Sets it not to destroy
        DontDestroyOnLoad(this);

        //Checks if there is another instance of this object, if there isn't it will set itself as the sole controller instance, if there is it will destroy itself if it isn't the original controller instance
        if (ControllerInstance == null)
        {
            ControllerInstance = this;
        }
        else
        {
            Object.Destroy(gameObject);
        }
    }
}
