using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomiseOptions : MonoBehaviour
{

    private float deskSwitchRandom;
    private float interfaceSwitchRandom;
    private float computerSwitchRandom;
    private float speakersSwitchRandom;
    private float ignoreErrorsRandom;
    private float dynamicProcessingRandom;
    private float videoEngineRandom;

    private int playbackEngineRandom;
    private int bufferSizeRandom;
    private int cacheSizeRandom;

    public void Randomise()
    {
        //True-False Variables
        deskSwitchRandom = Random.Range(0f, 1f);
        interfaceSwitchRandom = Random.Range(0f, 1f);
        computerSwitchRandom = Random.Range(0f, 1f);
        speakersSwitchRandom = Random.Range(0f, 1f);
        ignoreErrorsRandom = Random.Range(0f, 1f);
        dynamicProcessingRandom = Random.Range(0f, 1f);
        videoEngineRandom = Random.Range(0f, 1f);

        if (deskSwitchRandom < 0.5)
        {
            UniversalVariables.deskSwitch = true;
        }
        else
        {
            UniversalVariables.deskSwitch = false;
        }

        if (interfaceSwitchRandom < 0.5)
        {
            UniversalVariables.interfaceSwitch = false;
        }
        else
        {
            UniversalVariables.interfaceSwitch = true;
        }

        if (computerSwitchRandom < 0.5)
        {
            UniversalVariables.computerSwitch = false;
        }
        else
        {
            UniversalVariables.computerSwitch = true;
        }

        if (speakersSwitchRandom < 0.5)
        {
            UniversalVariables.speakersSwitch = false;
        }
        else
        {
            UniversalVariables.speakersSwitch = true;
        }

        if (ignoreErrorsRandom < 0.5)
        {
            UniversalVariables.ignoreErrors = false;
        }
        else
        {
            UniversalVariables.ignoreErrors = true;
        }

        if (dynamicProcessingRandom < 0.5)
        {
            UniversalVariables.dynamicProcessing = false;
        }
        else
        {
            UniversalVariables.dynamicProcessing = true;
        }

        if (videoEngineRandom < 0.5)
        {
            UniversalVariables.videoEngine = false;
        }
        else
        {
            UniversalVariables.videoEngine = true;
        }

        //Varied Variables
        playbackEngineRandom = Random.Range(0, 5);
        bufferSizeRandom = Random.Range(0, 5);
        cacheSizeRandom = Random.Range(0, 13);

        UniversalVariables.playbackEngineDropdown = playbackEngineRandom;
        UniversalVariables.bufferDropdown = bufferSizeRandom;
        UniversalVariables.cacheSizeDropdown = cacheSizeRandom;
    }

}
