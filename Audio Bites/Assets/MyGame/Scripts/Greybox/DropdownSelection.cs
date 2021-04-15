using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropdownSelection : MonoBehaviour
{
    public void HandleInputDate(int val)
    {
        if (this.gameObject.name == "Playback Engine")
        {
            UniversalVariables.playbackEngineDropdown = val;
        }
        if (this.gameObject.name == "Buffer Size")
        {
            UniversalVariables.bufferDropdown = val;
        }
        if (this.gameObject.name == "Cache Size")
        {
            UniversalVariables.cacheSizeDropdown = val;
        }

    }
}
