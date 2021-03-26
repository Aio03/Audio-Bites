using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCheckBox : MonoBehaviour
{
    public Transform tick;
    private bool universalSwitchVar;

    void Update()
    {
        //Check Which Object this is
        if (this.gameObject.name == "Ignore Errors Box")
        {
            universalSwitchVar = UniversalVariables.ignoreErrors;
        }
        if (this.gameObject.name == "Dynamic Processing Box")
        {
            universalSwitchVar = UniversalVariables.dynamicProcessing;
        }
        if (this.gameObject.name == "Video Engine Box")
        {
            universalSwitchVar = UniversalVariables.videoEngine;
        }


        //Turn on/off child objects
        if (universalSwitchVar == true)
        {
            tick.gameObject.SetActive(true);
        }
        else
        {
            tick.gameObject.SetActive(false);
        }
    }
}
