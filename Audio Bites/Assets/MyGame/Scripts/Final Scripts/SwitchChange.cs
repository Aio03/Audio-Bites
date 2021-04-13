using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchChange : MonoBehaviour
{
    [Header("Children")]
    public Transform off;
    public Transform on;
    private bool switchVar;

    private ConsistentVariables variables;
    private void Start()
    {
        ///Finds the variables needed from the GameController
        variables = GameObject.FindGameObjectWithTag("GameController").GetComponent<ConsistentVariables>();
    }

    void Update()
    {
        //Check Which Object this is
        if (this.gameObject.name == "Desk")
        {
            switchVar = variables.deskPower;
        }
        if (this.gameObject.name == "Interface")
        {
            switchVar = variables.interfacePower;
        }
        if (this.gameObject.name == "ComputerPower")
        {
            switchVar = variables.computerPower;
        }
        if (this.gameObject.name == "Speaker")
        {
            switchVar = variables.speakerPower;
        }
        if (this.gameObject.name == "Power")
        {
            switchVar = variables.power;
        }

        if (this.gameObject.name == "IgnoreErrors")
        {
            switchVar = variables.ignoreErrors;
        }
        if (this.gameObject.name == "Dynamic")
        {
            switchVar = variables.dynamic;
        }
        if (this.gameObject.name == "VideoEngine")
        {
            switchVar = variables.videoEngine;
        }

        if (this.gameObject.name == "ClipboardButton")
        {
            switchVar = variables.clipboardShown;
        }

        //Turn on/off child objects
        if (switchVar == true)
        {
            off.gameObject.SetActive(false);
            on.gameObject.SetActive(true);
        }
        else
        {
            off.gameObject.SetActive(true);
            on.gameObject.SetActive(false);
        }
    }
}
