using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script is to find what the player has done and add them to variables so that grading may be done once complete
/// The script also handles the grading shown at the end
/// </summary>

public class Grading : MonoBehaviour
{
    //This variable is to check if the switch is done in the correct order, I can't for the life of me figure out a better and cleaner option so  ???
    public float uniqueSwitchCode;
    private bool powerSwitchAdded;
    private bool deskSwitchAdded;
    private bool interfaceSwitchAdded;
    private bool computerSwitchAdded;
    private bool speakersSwitchAdded;


    private void Update()
    {
        //Check if the system was reset to factory before beginning
        if (UniversalVariables.powerSwitch == false && UniversalVariables.deskSwitch == false && UniversalVariables.interfaceSwitch == false && UniversalVariables.computerSwitch == false && UniversalVariables.speakersSwitch == false)
        {
            UniversalVariables.resetSystemFirst = true;
            uniqueSwitchCode = 0f;
        }

        if (UniversalVariables.powerSwitch == true)
        {
            if (powerSwitchAdded == false)
            {
                uniqueSwitchCode++;
                powerSwitchAdded = true;
            }
        } 
        else
        {
            if (powerSwitchAdded == true)
            {
                uniqueSwitchCode--;
                powerSwitchAdded = false;
            }
        }

        if (UniversalVariables.deskSwitch == true)
        {
            if (deskSwitchAdded == false)
            {
                uniqueSwitchCode = uniqueSwitchCode * 5;
                deskSwitchAdded = true;
            }
        }
        else
        {
            if (deskSwitchAdded == true)
            {
                uniqueSwitchCode = uniqueSwitchCode / 5;
                deskSwitchAdded = false;
            }
        }

        if (UniversalVariables.interfaceSwitch == true)
        {
            if (interfaceSwitchAdded == false)
            {
                uniqueSwitchCode = uniqueSwitchCode / 2f;
                interfaceSwitchAdded = true;
            }
        }
        else
        {
            if (interfaceSwitchAdded == true)
            {
                uniqueSwitchCode = uniqueSwitchCode * 2f;
                interfaceSwitchAdded = false;
            }
        }

        if (UniversalVariables.computerSwitch == true)
        {
            if (computerSwitchAdded == false)
            {
                uniqueSwitchCode = uniqueSwitchCode + 2.7f;
                computerSwitchAdded = true;
            }
        }
        else
        {
            if (computerSwitchAdded == true)
            {
                uniqueSwitchCode = uniqueSwitchCode - 2.7f;
                computerSwitchAdded = false;
            }
        }

        if (UniversalVariables.speakersSwitch == true)
        {
            if (speakersSwitchAdded == false)
            {
                uniqueSwitchCode = uniqueSwitchCode / 2.5f;
                speakersSwitchAdded = true;
            }
        }
        else
        {
            if (speakersSwitchAdded == true)
            {
                uniqueSwitchCode = uniqueSwitchCode * 2.5f;
                speakersSwitchAdded = false;
            }
        }

        if (uniqueSwitchCode == 2.08)
        {
            UniversalVariables.c_Order_DICS = true;
        } 
        else
        {
            UniversalVariables.c_Order_DICS = false;
        }
    }
}
