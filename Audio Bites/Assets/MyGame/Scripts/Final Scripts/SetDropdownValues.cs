using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/// <summary>
/// Allows the consistency of the dropdown values betweeen scenes, finding the values set in the DropdownHandleInput script and sets them at each start of a scene. Doesn't currently work
/// </summary>

public class SetDropdownValues : MonoBehaviour
{
    TMP_Dropdown dropdown;
    string message;
    int dropdownValue;

    bool dropdownFound;

    private ConsistentVariables variables;
    private void Start()
    {
        ///Finds the variables needed from the GameController
        variables = GameObject.FindGameObjectWithTag("GameController").GetComponent<ConsistentVariables>();
    }

    private void Awake()
    {
        //Finds the correct dropdown component, uses a bool to see if its found it so it doesn't attempt to find it at the start of each scene change back
        if (dropdownFound == false)
        {
            dropdown = GetComponent<TMP_Dropdown>();
            dropdownFound = true;
        }

        if (dropdown != null)
        {
            //Playback Engine Size Dropdown
            if (this.gameObject.name == "PlaybackEngineDropdown")
            {
                //sets the value of the dropdown to what is found in the consistent variables value
                dropdown.value = variables.playbackEngine;
                //sets the message to the correct text attached to the value
                message = dropdown.options[variables.playbackEngine].text;
            }

            //Buffer Size Dropdown
            if (this.gameObject.name == "BufferSizeDropdown")
            {
                dropdown.value = variables.bufferSize;
                message = dropdown.options[variables.bufferSize].text;
            }

            //Cache Size Dropdown
            if (this.gameObject.name == "CacheSizeDropdown")
            {
                dropdown.value = variables.cacheSize;
                message = dropdown.options[variables.cacheSize].text;
            }
        }
    }
}
