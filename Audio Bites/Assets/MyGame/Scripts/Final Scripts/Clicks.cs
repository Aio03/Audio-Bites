using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Manages when the player clicks on screen for non-buttons, non-dropdowns
/// </summary>

public class Clicks : MonoBehaviour
{
    private bool fading = false;
    private string sceneName;

    public LayerMask IgnoreMe;

    //Variables
    private ConsistentVariables variables;

    //For playing sounds
    SFX soundEffects;

    private void Start()
    {
        ///Finds the variables needed from the GameController
        variables = GameObject.FindGameObjectWithTag("GameController").GetComponent<ConsistentVariables>();
        soundEffects = variables.gameObject.GetComponent<SFX>();
    }

    private void Update()
    {
        ///Gets the mouse input
        if (Input.GetMouseButtonDown(0))
        {
            
            ///Finds the mouse position
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            ///Casts a raycast using the mouse position
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero, Mathf.Infinity, ~IgnoreMe);

            ///Checks if the raycast hit anything
            if (hit.collider != null)
            {
                //print(hit.collider.gameObject.name);
                ///Makes temporary variable of what the raycast hit so we can call it later
                var objectName = hit.collider.gameObject.name;

                ///Calls
                //Light Switch
                if (objectName == "LightSwitch")
                {
                    variables.lights = !variables.lights;
                    soundEffects.PlaySwitchSoundOne();
                }

                //Back Desk Arrow Scene Change
                if (objectName == "BackDeskArrow")
                {
                    SceneChange("04_BackDesk");
                }

                //Front Desk Arrow Scene Change
                if (objectName == "FrontDeskArrow")
                {
                    SceneChange("03_FrontDesk");
                }

                //Power Ports Switches
                if (objectName == "Power")
                {
                    soundEffects.PlaySwitchSoundTwo();
                    variables.power = !variables.power;
                }

                //Computer Scene Inspect
                if (objectName == "Computer")
                {
                    if (variables.computerIsOn)
                    {
                        SceneChange("05_Computer");
                    }
                }

                //Speaker Switch
                if (objectName == "Speaker")
                {
                    soundEffects.PlaySuctionHoodButton();
                    variables.speakerPower = !variables.speakerPower;
                }

                //Desk Switch
                if (objectName == "Desk")
                {
                    soundEffects.PlaySuctionHoodButton();
                    variables.deskPower = !variables.deskPower;
                }

                //Interface Switch
                if (objectName == "Interface")
                {
                    soundEffects.PlaySuctionHoodButton();
                    variables.interfacePower = !variables.interfacePower;
                }

                //Computer Power Switch
                if (objectName == "ComputerPower")
                {
                    soundEffects.PlaySuctionHoodButton();
                    variables.computerPower = !variables.computerPower;
                }

                //Ignore Errors Option
                if (objectName == "IgnoreErrors")
                {
                    variables.ignoreErrors = !variables.ignoreErrors;
                }

                //Dynamic Option
                if (objectName == "Dynamic")
                {
                    variables.dynamic = !variables.dynamic;
                }

                //Video Engine Option
                if (objectName == "VideoEngine")
                {
                    variables.videoEngine = !variables.videoEngine;
                }

                //Setup on Protools Click
                if (objectName == "Setup")
                {
                    var playbackEngine = GameObject.Find("PlaybackEngine");
                    var playbackImage = playbackEngine.gameObject.transform.GetChild(0);
                    playbackImage.gameObject.SetActive(true);
                }

                //Playback Engine Okay Button
                if (objectName == "PlaybackEngine_Okay")
                {
                    var playbackEngine = GameObject.Find("PlaybackEngine");
                    var playbackImage = playbackEngine.gameObject.transform.GetChild(0);
                    playbackImage.gameObject.SetActive(false);

                    var areYouDone = GameObject.Find("AreYouDone");
                    var areYouDoneImage = areYouDone.gameObject.transform.GetChild(0);
                    areYouDoneImage.gameObject.SetActive(true);
                }

                //Are You Done Yes Answer
                if (objectName == "YesDone")
                {
                    SceneChange("06_Grade");
                }

                //Are You Done No Answer
                if (objectName == "NoDone")
                {
                    hit.collider.gameObject.transform.parent.gameObject.SetActive(false);
                }

                //Restart in Grading Screen
                if (objectName == "Restart")
                {
                    SceneChange("07_Reset");
                }

                //Video Engine Option
                if (objectName == "ClipboardButton")
                {
                    variables.clipboardShown = !variables.clipboardShown;
                }

                //Game Setting Loud Noises
                if (objectName == "Opt_LoudSounds")
                {
                    StaticSettings.loudNoises = !StaticSettings.loudNoises;
                }

                //Game Settings Music
                if (objectName == "Opt_Music")
                {
                    StaticSettings.music = !StaticSettings.music;
                }

                //Game Settings Sound Effects
                if (objectName == "Opt_SoundEffects")
                {
                    StaticSettings.soundEffects = !StaticSettings.soundEffects;
                }


                ////Example of switching variables with a click
                //if (objectName == "OBJECTNAME")
                //{
                //    variables.VARIABLE = !variables.VARIABLE;
                //}



            }
        }

        //Since we don't want the scene to change until the fading has completed and we can't stay in the scene change function while we wait for the fade to complete
        // we have to add a section into the update function with some single use variables to check if fading is complete, then for it to change scene based on the 
        // "SceneChange" function variables.
        if (fading == true)
        {
            var fader = GameObject.Find("FadingImage").GetComponent<FadeToBlack>();
            if (fader.doneFading == true)
            {
                SceneManager.LoadScene(sceneName: sceneName);
                fader.doneFading = false;
                fading = false;
            }
        }

    }

    //Sets up the fading within the fading object and sets the relevant variables for scene change
    public void SceneChange(string Scene)
    {
        fading = true;
        var fader = GameObject.Find("FadingImage").GetComponent<FadeToBlack>();
        fader.Fade(true, 3);

        sceneName = Scene;
    }

}
