using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A script on the game manager which keeps consistent variables throughout the scenes
/// </summary>

public class ConsistentVariables : MonoBehaviour
{
    //Basic Variables
    [HideInInspector]
    public bool lights = true;

    //Real Switches
    [HideInInspector]
    public bool power;
    [HideInInspector]
    public bool deskPower;
    [HideInInspector]
    public bool interfacePower;
    [HideInInspector]
    public bool computerPower;
    [HideInInspector]
    public bool speakerLeftPower;
    [HideInInspector]
    public bool speakerRightPower;

    //Protools tickables
    [HideInInspector]
    public bool ignoreErrors;
    [HideInInspector]
    public bool dynamic;
    [HideInInspector]
    public bool videoEngine;

    //Protools dropdowns
    [HideInInspector]
    public int playbackEngine;
    [HideInInspector]
    public int bufferSize;
    [HideInInspector]
    public int cacheSize;

}
