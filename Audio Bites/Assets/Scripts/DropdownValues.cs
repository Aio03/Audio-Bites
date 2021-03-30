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

    private void Start()
    {
        dropdown = GetComponent<TMP_Dropdown>();
    }

    private void Awake()
    {
        //Playback Engine Size Dropdown
        if (this.gameObject.name == "Playback Engine")
        {
            dropdown.value = UniversalVariables.playbackEngineDropdown;
            message = dropdown.options[UniversalVariables.playbackEngineDropdown].text;
        }

        //Buffer Size Dropdown
        if (this.gameObject.name == "Buffer Size")
        {
            dropdown.value = UniversalVariables.bufferDropdown;
            message = dropdown.options[UniversalVariables.bufferDropdown].text;
        }

        //Cache Size Dropdown
        if (this.gameObject.name == "Cache Size")
        {
            dropdown.value = UniversalVariables.cacheSizeDropdown;
            message = dropdown.options[UniversalVariables.cacheSizeDropdown].text;
        }
        //text.text = message;
    }
}
