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
    [HideInInspector]
    public bool computerIsOn;
    [HideInInspector]
    public bool clipboardShown;

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
    public bool speakerPower;

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

    //Soley Grading Variables
    [HideInInspector]
    public bool resetSystem;
    [HideInInspector]
    public bool switchesOrder;

    //Scenario Specific Variables
    [HideInInspector]
    public int wantedBufferSize;
    [HideInInspector]
    public bool wantedIgnoreErrors;
    [HideInInspector]
    public bool wantedDynamicProcessing;

    //Gremlin Variables
    [HideInInspector]
    public bool haveGremlinsArrived;

    private void Update()
    {
        if (power == true && computerPower == true)
        {
            computerIsOn = true;
        }
        else
        {
            computerIsOn = false;
        }
    }

}
