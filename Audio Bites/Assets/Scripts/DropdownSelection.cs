using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropdownSelection : MonoBehaviour
{

    
    

    //Debugging check for buffer size
    private void Update()
    {
        print("buffer size: " + UniversalVariables.bufferSize);
        print("playback engine dropdown value: " + UniversalVariables.playbackEngineDropdown);
        print("buffer size dropdown value: " + UniversalVariables.bufferDropdown);
        print("cache size dropdown value: " + UniversalVariables.cacheSizeDropdown);
    }

    //This function handles the dropdown values
    public void HandleInputData(int val)
    {
        /// Each of these will set the universal variables depending on what option chosen
        //Playback Engine Dropdown
        if (this.gameObject.name == "Playback Engine")
        {
            if (val == 0)
            {
                UniversalVariables.playbackEngine = false;
            }
            if (val == 1)
            {
                UniversalVariables.playbackEngine = false;
            }
            if (val == 2)
            {
                UniversalVariables.playbackEngine = true;
            }
            UniversalVariables.playbackEngineDropdown = val;
            print("Playback Engine val: " + val);
        }

        //Buffer Size Dropdown
        if (this.gameObject.name == "Buffer Size")
        {
            if (val == 0)
            {
                UniversalVariables.bufferSize = 32;
            }
            if (val == 1)
            {
                UniversalVariables.bufferSize = 64;
            }
            if (val == 2)
            {
                UniversalVariables.bufferSize = 128;
            }
            if (val == 3)
            {
                UniversalVariables.bufferSize = 256;
            }
            if (val == 4)
            {
                UniversalVariables.bufferSize = 512;
            }
            if (val == 5)
            {
                UniversalVariables.bufferSize = 1024;
            }
            UniversalVariables.bufferDropdown = val;
            print("Buffer Size val: " + val);
        }

        //Cache Size Dropdown
        if (this.gameObject.name == "Cache Size")
        {
            if (val == 0)
            {
                UniversalVariables.cacheNormal = true;
                UniversalVariables.cacheSize = 0f;
            }
            if (val == 1)
            {
                UniversalVariables.cacheNormal = false;
                UniversalVariables.cacheSize = 0.256f;
            }
            if (val == 2)
            {
                UniversalVariables.cacheNormal = false;
                UniversalVariables.cacheSize = 0.512f;
            }
            if (val == 3)
            {
                UniversalVariables.cacheNormal = false;
                UniversalVariables.cacheSize = 1f;
            }
            if (val == 4)
            {
                UniversalVariables.cacheNormal = false;
                UniversalVariables.cacheSize = 2f;
            }
            if (val == 5)
            {
                UniversalVariables.cacheNormal = false;
                UniversalVariables.cacheSize = 3f;
            }
            if (val == 6)
            {
                UniversalVariables.cacheNormal = false;
                UniversalVariables.cacheSize = 4f;
            }
            if (val == 7)
            {
                UniversalVariables.cacheNormal = false;
                UniversalVariables.cacheSize = 5f;
            }
            if (val == 8)
            {
                UniversalVariables.cacheNormal = false;
                UniversalVariables.cacheSize = 6f;
            }
            if (val == 9)
            {
                UniversalVariables.cacheNormal = false;
                UniversalVariables.cacheSize = 7f;
            }
            if (val == 10)
            {
                UniversalVariables.cacheNormal = false;
                UniversalVariables.cacheSize = 8f;
            }
            if (val == 11)
            {
                UniversalVariables.cacheNormal = false;
                UniversalVariables.cacheSize = 9f;
            }
            if (val == 12)
            {
                UniversalVariables.cacheNormal = false;
                UniversalVariables.cacheSize = 10f;
            }
            if (val == 13)
            {
                UniversalVariables.cacheNormal = false;
                UniversalVariables.cacheSize = 12f;
            }
            UniversalVariables.cacheSizeDropdown = val;
            print("Cache Size val: " + val);
        }

    }
}
