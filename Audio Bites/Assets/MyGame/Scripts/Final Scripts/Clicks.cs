using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Manages when the player clicks on screen for non-buttons, non-dropdowns
/// </summary>

public class Clicks : MonoBehaviour
{

    public LayerMask IgnoreMe;

    //Variables
    private ConsistentVariables variables;

    private void Start()
    {
        ///Finds the variables needed from the GameController
        variables = GameObject.FindGameObjectWithTag("GameController").GetComponent<ConsistentVariables>();
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
                    variables.power = !variables.power;
                }

                //Computer Scene Inspect
                if (objectName == "Computer")
                {
                    SceneChange("05_Computer");
                }

                //Left Speaker Switch
                if (objectName == "LeftSpeaker")
                {
                    variables.speakerLeftPower = !variables.speakerLeftPower;
                }

                //Right Speaker Switch
                if (objectName == "RightSpeaker")
                {
                    variables.speakerRightPower = !variables.speakerRightPower;
                }

                //Desk Switch
                if (objectName == "Desk")
                {
                    variables.deskPower = !variables.deskPower;
                }

                //Interface Switch
                if (objectName == "Interface")
                {
                    variables.interfacePower = !variables.interfacePower;
                }

                //Computer Power Switch
                if (objectName == "ComputerPower")
                {
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
                }

                ////Example of switching variables with a click
                //if (objectName == "OBJECTNAME")
                //{
                //    variables.VARIABLE = !variables.VARIABLE;
                //}



            }

        }
    }

    public void SceneChange(string Scene)
    {
        SceneManager.LoadScene(sceneName: Scene);
    }

}
