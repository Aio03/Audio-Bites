using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSwitchOnOff : MonoBehaviour
{
    [Header("Children")]
    public Transform redLight;
    public Transform greenLight;
    private bool universalSwitchVar;
    
    /// This section is for a script no longer used
    /*
    private Switch switchScript;
    private bool switched;

    private void Start()
    {
        switchScript = GetComponent<Switch>();
    }*/

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
            
            /*Unused
            if (switched == false)
            {
                print("switched called");
                switchScript.SwitchPressed();
                switched = true;
            }*/
        }
        else
        {
            redLight.gameObject.SetActive(true);
            greenLight.gameObject.SetActive(false);
            
            /* Unused
            switched = false;*/
        }
    }
}
