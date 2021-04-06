using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Manages when the player clicks on screen for non-buttons, non-dropdowns
/// </summary>

public class Clicks : MonoBehaviour
{
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
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            ///Checks if the raycast hit anything
            if (hit.collider != null)
            {
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

    public void SceneChange(string Scene)
    {
        SceneManager.LoadScene(sceneName: Scene);
    }

}
