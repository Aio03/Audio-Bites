using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Handles all the static variables (the ones that need to stay the same between scenes) so that other objects can grab from it
/// Key: (un - unused) | (c_ - correct)
/// </summary>

public static class UniversalVariables
{
    //Management Variables
    public static bool haveTimersBeenSet;
    public static bool gradeScreen = false;

    //In-Game Variables
    public static bool lightSwitch = true;

    public static bool deskSwitch;
    public static bool interfaceSwitch;
    public static bool computerSwitch;
    public static bool speakersSwitch;
    public static bool powerSwitch;

    public static bool playbackEngine; //un
    public static int bufferSize = 32; //un
    public static bool ignoreErrors;
    public static bool dynamicProcessing;
    public static bool videoEngine;
    public static bool cacheNormal = true; //un
    public static float cacheSize; //un

    //Dropdown Values
    public static int playbackEngineDropdown;
    public static int bufferDropdown;
    public static int cacheSizeDropdown;

    //Grading Specific Variables
    public static bool resetSystemFirst;
    public static bool c_Order_DICS;

    /// <summary>
    /// This function resets all the variables so the player can replay the game
    /// </summary>
    static public void Reset()
    {
        haveTimersBeenSet = false;

        lightSwitch = true;

        deskSwitch = false;
        interfaceSwitch = false;
        computerSwitch = false;
        speakersSwitch = false;
        speakersSwitch = false;
        powerSwitch = false;

        playbackEngine = false; //un
        bufferSize = 32; //un
        ignoreErrors = false;
        dynamicProcessing = false;
        videoEngine = false;
        cacheNormal = true; //un
        cacheSize = 0; //un

        playbackEngineDropdown = 0;
        bufferDropdown = 0;
        cacheSizeDropdown = 0;

        resetSystemFirst = false;
        c_Order_DICS = false;
    }

}
