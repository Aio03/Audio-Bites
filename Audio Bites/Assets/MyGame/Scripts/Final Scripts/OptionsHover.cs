using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OptionsHover : MonoBehaviour
{

    public TextMeshProUGUI optionsInformation;
    private bool hovering;

    private void Update()
    {
        if (hovering == false)
        {
            optionsInformation.text = "";
        }
    }

    private void OnMouseEnter()
    {
        optionsInformation.text = "Disabling this removes any sudden and loud noises in game";
        hovering = true;
    }

    private void OnMouseExit()
    {
        hovering = false;
    }
}
