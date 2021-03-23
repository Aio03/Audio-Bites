using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSwitchOnOff : MonoBehaviour
{
    private Transform redLight;
    private Transform greenLight;
    private bool universalSwitchVar;

    private void Start()
    {
        redLight = gameObject.transform.GetChild(0);
        greenLight = gameObject.transform.GetChild(1);
    }

    void Update()
    {
        //Check Which Object this is
        if (this.gameObject.name == "Desk Switch")
        {
            universalSwitchVar = UniversalVariables.deskSwitch;
        }
        if (this.gameObject.name == "Interface Switch")
        {
            universalSwitchVar = UniversalVariables.interfaceSwitch;
        }
        if (this.gameObject.name == "Computer Switch")
        {
            universalSwitchVar = UniversalVariables.computerSwitch;
        }
        if (this.gameObject.name == "Speakers Switch")
        {
            universalSwitchVar = UniversalVariables.speakersSwitch;
        }
        if (this.gameObject.name == "Power Switch")
        {
            universalSwitchVar = UniversalVariables.powerSwitch;
        }

        //Turn on/off child objects
        if (universalSwitchVar == true)
        {
            redLight.gameObject.SetActive(false);
            greenLight.gameObject.SetActive(true);
        }
        else
        {
            redLight.gameObject.SetActive(true);
            greenLight.gameObject.SetActive(false);
        }
    }
}
