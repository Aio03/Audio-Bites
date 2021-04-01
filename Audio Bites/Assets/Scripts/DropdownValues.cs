using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropdownValues : MonoBehaviour
{
    TMP_Dropdown dropdown;
    string message;
    //public TMP_Text text;
    int dropdownValue;

    bool dropdownFound;

    private void Awake()
    {
        if (dropdownFound == false)
        {
            dropdown = GetComponent<TMP_Dropdown>();
            dropdownFound = true;
        }
        
        if (dropdown != null)
        {
            //Playback Engine Size Dropdown
            if (this.gameObject.name == "Playback Engine Dropdown")
            {
                dropdown.value = UniversalVariables.playbackEngineDropdown;
                message = dropdown.options[UniversalVariables.playbackEngineDropdown].text;
                print("UniversalVariables PE Dropdown int: " + UniversalVariables.playbackEngineDropdown);
            }

            //Buffer Size Dropdown
            if (this.gameObject.name == "Buffer Size Dropdown")
            {
                dropdown.value = UniversalVariables.bufferDropdown;
                message = dropdown.options[UniversalVariables.bufferDropdown].text;
                print("UniversalVariables BS Dropdown int: " + UniversalVariables.bufferDropdown);
            }

            //Cache Size Dropdown
            if (this.gameObject.name == "Cache Size Dropdown")
            {
                dropdown.value = UniversalVariables.cacheSizeDropdown;
                message = dropdown.options[UniversalVariables.cacheSizeDropdown].text;
                print("UniversalVariables CS Dropdown int: " + UniversalVariables.cacheSizeDropdown);
            }
        }
    }

}
