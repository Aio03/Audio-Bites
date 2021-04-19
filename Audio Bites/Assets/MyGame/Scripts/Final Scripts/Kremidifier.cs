using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Handles when the gremlins appear
/// 1- Fades the screen to black and stops timer
/// 2- Activate Gremlin Laugh
/// 3- Randomise Variables
/// 4- Lights off
/// 5- Change scene to Front Desk and un-fade from black
/// In that order mostly
/// </summary>

public class Kremidifier : MonoBehaviour
{
    [HideInInspector]
    public bool activateCoroutine;

    private void Update()
    {
        if (activateCoroutine == true)
        {
            StartCoroutine(GremlinArrival(3));
            activateCoroutine = false;
        }
    }

    //For playing sounds
    SFX soundEffects;

    //Variables
    private ConsistentVariables variables;

    private void Start()
    {
        ///Finds the variables needed from the GameController
        variables = GameObject.FindGameObjectWithTag("GameController").GetComponent<ConsistentVariables>();
        soundEffects = variables.gameObject.GetComponent<SFX>();
    }

    public IEnumerator GremlinArrival(float lengthOfLaugh)
    {
        /////////Stop timer
        
        //Find the fading object
        var fader = GameObject.Find("FadingImage").GetComponent<FadeToBlack>();
        //Activate the fader's fade, check FadeToBlack script for more information
        fader.Fade(true, 3);

        //Play Thunder Sound
        soundEffects.PlayThunderClap();

        //Wait the same time as the fade
        yield return new WaitForSeconds(3);

        //Play Gremlin Laugh sound
        soundEffects.PlayGremlinLaugh();
        
        //Wait for length of the sound
        yield return new WaitForSeconds(lengthOfLaugh);
        //Activate the randomise function for randomising the variables
        RandomiseVariables();
        //Turns off lights
        variables.lights = false;
        //Changes scene to the front desk
        SceneManager.LoadScene(sceneName: "03_FrontDesk");
        //Enables the Text box, then waits 4 seconds then destroys it
        yield return new WaitForSeconds(0.4f);
        var textBox = GameObject.Find("TextboxCanvas");
        textBox.transform.GetChild(0).gameObject.SetActive(true);
        textBox.transform.GetChild(1).gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        textBox.transform.GetChild(0).gameObject.SetActive(false);
        textBox.transform.GetChild(1).gameObject.SetActive(false);
        //Finishes coroutine
        yield return null;
    }

    //The randomising variables
    private float deskSwitchRandom;
    private float interfaceSwitchRandom;
    private float speakersSwitchRandom;
    private float ignoreErrorsRandom;
    private float dynamicProcessingRandom;
    private float videoEngineRandom;

    private int playbackEngineRandom;
    private int bufferSizeRandom;
    private int cacheSizeRandom;



    private void RandomiseVariables()
    {
        variables.computerPower = false;

        //True-False Variables
        deskSwitchRandom = Random.Range(0f, 1f);
        interfaceSwitchRandom = Random.Range(0f, 1f);
        speakersSwitchRandom = Random.Range(0f, 1f);
        ignoreErrorsRandom = Random.Range(0f, 1f);
        dynamicProcessingRandom = Random.Range(0f, 1f);
        videoEngineRandom = Random.Range(0f, 1f);

        //Decides variables based on randomised between 0 and 1, if below 0.5 itll be true, above or equal to 0.5 itll be false
        if (deskSwitchRandom < 0.5)
        {
            variables.deskPower = true;
        }
        else
        {
            variables.deskPower = false;
        }

        if (interfaceSwitchRandom < 0.5)
        {
            variables.interfacePower = false;
        }
        else
        {
            variables.interfacePower = true;
        }

        if (speakersSwitchRandom < 0.5)
        {
            variables.speakerPower = false;
        }
        else
        {
            variables.speakerPower = true;
        }

        if (ignoreErrorsRandom < 0.5)
        {
            variables.ignoreErrors = false;
        }
        else
        {
            variables.ignoreErrors = true;
        }

        if (dynamicProcessingRandom < 0.5)
        {
            variables.dynamic = false;
        }
        else
        {
            variables.dynamic = true;
        }

        if (videoEngineRandom < 0.5)
        {
            variables.videoEngine = false;
        }
        else
        {
            variables.videoEngine = true;
        }

        //Varied Variables
        playbackEngineRandom = Random.Range(0, 5);
        bufferSizeRandom = Random.Range(0, 5);
        cacheSizeRandom = Random.Range(0, 13);

        variables.playbackEngine = playbackEngineRandom;
        variables.bufferSize = bufferSizeRandom;
        variables.cacheSize = cacheSizeRandom;
    }

}
