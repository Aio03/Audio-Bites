using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance { get { return instance; } }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

        if (instance == null)
        {
            instance = this;
        } else
        {
            Destroy(this);
        }
        MenuManager.Instance.TurnOnSettingsMenu();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            if (hit.collider != null)
            {
                //Debug.Log("Something was clicked!");
                //Debug.Log(hit.collider.gameObject.name);
                
                var objectName = hit.collider.gameObject.name;

                //Front Desk Change Scene Click
                if (objectName == "FrontDeskClick")
                {
                    MenuManager.Instance.TurnOffSettingsMenu();
                    SceneChange("GB_FrontDesk");
                }

                //Back Desk Change Scene Click
                if (objectName == "BackDeskClick")
                {
                    MenuManager.Instance.TurnOffSettingsMenu();
                    SceneChange("GB_BackDesk");
                }

                //Computer Screen Change Scene Click
                if (objectName == "ScreenClick")
                {
                    MenuManager.Instance.TurnOnSettingsMenu();
                    SceneChange("GB_ComputerScreen");
                }

                //Light Switch On/Off Click
                if (objectName == "LightSwitchClick")
                {
                    if (UniversalVariables.lightSwitch == false)
                    {
                        UniversalVariables.lightSwitch = true;
                    } else
                    {
                        UniversalVariables.lightSwitch = false;
                    }
                }

                //Desk Switch On/Off bClick
                if (objectName == "DeskSwitchClick")
                {
                    if (UniversalVariables.deskSwitch == false)
                    {
                        UniversalVariables.deskSwitch = true;
                    }
                    else
                    {
                        UniversalVariables.deskSwitch = false;
                    }
                }

                //Interface On/Off Click
                if (objectName == "InterfaceSwitchClick")
                {
                    if (UniversalVariables.interfaceSwitch == false)
                    {
                        UniversalVariables.interfaceSwitch = true;
                    }
                    else
                    {
                        UniversalVariables.interfaceSwitch = false;
                    }
                }

                //Computer On/Off Click
                if (objectName == "ComputerSwitchClick")
                {
                    if (UniversalVariables.computerSwitch == false)
                    {
                        UniversalVariables.computerSwitch = true;
                    }
                    else
                    {
                        UniversalVariables.computerSwitch = false;
                    }
                }

                //Speakers On/Off Click
                if (objectName == "SpeakersSwitchClick")
                {
                    if (UniversalVariables.speakersSwitch == false)
                    {
                        UniversalVariables.speakersSwitch = true;
                    }
                    else
                    {
                        UniversalVariables.speakersSwitch = false;
                    }
                }

                //Power On/Off Click
                if (objectName == "PowerSwitchClick")
                {
                    if (UniversalVariables.powerSwitch == false)
                    {
                        UniversalVariables.powerSwitch = true;
                    }
                    else
                    {
                        UniversalVariables.powerSwitch = false;
                    }
                }

                //Ignore Errors On/Off Click
                if (objectName == "IgnoreErrorsClick")
                {
                    if (UniversalVariables.ignoreErrors == false)
                    {
                        UniversalVariables.ignoreErrors = true;
                    }
                    else
                    {
                        UniversalVariables.ignoreErrors = false;
                    }
                }

                //Dynamic Processing On/Off Click
                if (objectName == "DynamicProcessingClick")
                {
                    if (UniversalVariables.dynamicProcessing == false)
                    {
                        UniversalVariables.dynamicProcessing = true;
                    }
                    else
                    {
                        UniversalVariables.dynamicProcessing = false;
                    }
                }

                //Video Engine On/Off Click
                if (objectName == "VideoEngineClick")
                {
                    if (UniversalVariables.videoEngine == false)
                    {
                        UniversalVariables.videoEngine = true;
                    }
                    else
                    {
                        UniversalVariables.videoEngine = false;
                    }
                }

                ////Comment Click
                //if (objectName == "")
                //{
                //    if (UniversalVariables. == false)
                //    {
                //        UniversalVariables. = true;
                //    }
                //    else
                //    {
                //        UniversalVariables. = false;
                //    }
                //}



            }

        }
    }

    private void SceneChange (string Scene)
    {
        SceneManager.LoadScene(sceneName: Scene);
    }

}
