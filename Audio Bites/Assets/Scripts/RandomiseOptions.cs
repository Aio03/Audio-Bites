using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomiseOptions : MonoBehaviour
{

    /*
    UniversalVariables.lightSwitch = true;

    UniversalVariables.deskSwitch;
    UniversalVariables.interfaceSwitch;
    UniversalVariables.computerSwitch;
    UniversalVariables.speakersSwitch;
    UniversalVariables.powerSwitch;

    UniversalVariables.playbackEngine;
    UniversalVariables.bufferSize = 32;
    UniversalVariables.ignoreErrors;
    UniversalVariables.dynamicProcessing;
    UniversalVariables.videoEngine;
    UniversalVariables.cacheNormal = true;
    UniversalVariables.cacheSize;
    */

    private int deskSwitchRandom;
    private int interfaceSwitchRandom;
    private int computerSwitchRandom;
    private int speakersSwitchRandom;
    private int playbackEngineRandom;
    private int bufferSizeRandom;
    private int ignoreErrorsRandom;
    private int dynamicProcessingRandom;
    private int videoEngineRandom;
    private int cacheSizeRandom;


    private bool haveOptionsChanged;

    private void Update()
    {
        if (haveOptionsChanged == false)
        {
            deskSwitchRandom = Random.Range(0, 1);
            interfaceSwitchRandom = Random.Range(0, 1);
            computerSwitchRandom = Random.Range(0, 1);
            speakersSwitchRandom = Random.Range(0, 1);
            playbackEngineRandom = Random.Range(0, 2);
            bufferSizeRandom = Random.Range(0, 5);
            ignoreErrorsRandom = Random.Range(0, 1);
            dynamicProcessingRandom = Random.Range(0, 1);
            videoEngineRandom = Random.Range(0, 1);
            cacheSizeRandom = Random.Range(0, 13);

            //True/False Variables
            if (deskSwitchRandom == 0)
            {
                UniversalVariables.deskSwitch = false;
            }
            else
            {
                UniversalVariables.deskSwitch = true;
            }

            if (interfaceSwitchRandom == 0)
            {
                UniversalVariables.interfaceSwitch = false;
            } 
            else
            {
                UniversalVariables.interfaceSwitch = true;
            }

            if (computerSwitchRandom == 0)
            {
                UniversalVariables.computerSwitch = false;
            }
            else
            {
                UniversalVariables.computerSwitch = true;
            }

            if (speakersSwitchRandom == 0)
            {
                UniversalVariables.speakersSwitch = false;
            }
            else
            {
                UniversalVariables.speakersSwitch = true;
            }

            if (ignoreErrorsRandom == 0)
            {
                UniversalVariables.ignoreErrors = false;
            }
            else
            {
                UniversalVariables.ignoreErrors = true;
            }

            if (dynamicProcessingRandom == 0)
            {
                UniversalVariables.dynamicProcessing = false;
            }
            else
            {
                UniversalVariables.dynamicProcessing = true;
            }

            if (videoEngineRandom == 0)
            {
                UniversalVariables.videoEngine = false;
            }
            else
            {
                UniversalVariables.videoEngine = true;
            }

            //Varied Variables
        }
    }
}
