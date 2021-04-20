using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/// <summary>
/// This script allows buttons to set which scenario it is, also handles changing the text of the introduction text
/// also sets the variables of the relevant scenario
/// </summary>
public class ScenarioSettings : MonoBehaviour
{
    //Variables
    bool sc_liveRecording;
    bool sc_mixing;

    TextMeshPro scenarioText;
    ScenarioTexts textInfo;

    private void Start()
    {
        //This basically checks if it is in the introduction scene then it will affect the text elements
        if (GameObject.Find("ScenarioText") != null)
        {
            scenarioText = GameObject.Find("ScenarioText").GetComponent<TextMeshPro>();
            textInfo = scenarioText.GetComponent<ScenarioTexts>();
        }
    }


    //For the button setting of the scenario in the introduction scene, changes the variables and text element
    void LiveRecording()
    {
        sc_liveRecording = true;
        sc_mixing = false;
        scenarioText.text = textInfo.liveRecordingText;
    }

    void Mixing()
    {
        sc_liveRecording = false;
        sc_mixing = true;
        scenarioText.text = textInfo.mixingText;
    }

}
