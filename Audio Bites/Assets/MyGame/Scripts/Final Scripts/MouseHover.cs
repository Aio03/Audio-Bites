using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/// <summary>
/// To check where the mouse is hovering and to activate stuff based on collisions
/// </summary>

public class MouseHover : MonoBehaviour
{
    //Variables
    private bool hovering = false;
    private GameObject followingText;
    private TextMeshProUGUI textElement;

    private ConsistentVariables variables;

    private void Start()
    {
        ///Finds the variables needed from the GameController
        variables = GameObject.FindGameObjectWithTag("GameController").GetComponent<ConsistentVariables>();
    }

    private void Awake()
    {
        //Finds the relevant hover text element (which is attached the the Main Camera Prefab in its children)
        followingText = GameObject.Find("FollowingText");
        textElement = followingText.GetComponent<TextMeshProUGUI>();
        //Removes text element text when awake so no text stays in place when scenes are changed (because that doesn't count as a trigger exit to Unity)
        textElement.text = "";
    }

    private void Update()
    {
        //Follow the cursor in sync
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //Removes text element text when it isn't hovering over anything
        if (hovering == false)
        {
            textElement.text = "";
        }

    }

    //On trigger finds if a relevant object was hovered over and if so it will change the text element to the relevant name
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "LightSwitch")
        {
            hovering = true;
            textElement.text = "Light Switch";
        }
        if (collision.gameObject.name == "BackDeskArrow")
        {
            hovering = true;
            textElement.text = "Go Behind the Desk";
        }
        if (collision.gameObject.name == "Power")
        {
            hovering = true;
            textElement.text = "Power Switch";
        }
        if (collision.gameObject.name == "Computer")
        {
            hovering = true;
            if (variables.computerIsOn == true)
            {
                textElement.text = "Go on the Computer";
            }
            else
            {
                textElement.text = "The Computer is off";
            }
        }
        if (collision.gameObject.name == "FrontDeskArrow")
        {
            hovering = true;
            textElement.text = "Go in Front of the Desk";
        }
        if (collision.gameObject.name == "Speaker")
        {
            hovering = true;
            textElement.text = "Speaker Power";
        }
        if (collision.gameObject.name == "Desk")
        {
            hovering = true;
            textElement.text = "Desk Power";
        }
        if (collision.gameObject.name == "Interface")
        {
            hovering = true;
            textElement.text = "Interface Power";
        }
        if (collision.gameObject.name == "ComputerPower")
        {
            hovering = true;
            textElement.text = "Computer Power";
        }
    }

    //On exit it sets the hovering to false once, only if hovering was already true, this is to stop hovering being set to false constantly as it exits colliders
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (hovering == true)
        {
            hovering = false;
        }
    }

}
