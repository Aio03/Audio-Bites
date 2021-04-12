using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Sets the input of the relevant dropdowns with the consistent variables
/// </summary>

public class DropdownHandleInput : MonoBehaviour
{

    private ConsistentVariables variables;
    private void Start()
    {
        ///Finds the variables needed from the GameController
        variables = GameObject.FindGameObjectWithTag("GameController").GetComponent<ConsistentVariables>();
    }

    //Connect this to the dropdown "On Value Changed" element to handle the input
    public void HandleInputData(int val)
    {
        //Finds which dropdown it is and sets its value with that
        if (this.gameObject.name == "PlaybackEngineOption")
        {
            variables.playbackEngine = val;
        }
        if (this.gameObject.name == "BufferSizeOption")
        {
            variables.bufferSize = val;
        }
        if (this.gameObject.name == "CacheSizeOption")
        {
            variables.cacheSize = val;
        }

    }
}
