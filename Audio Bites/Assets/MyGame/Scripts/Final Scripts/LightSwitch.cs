using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Dimming/lighting the room based on lights variable
/// </summary>

public class LightSwitch : MonoBehaviour
{
    private Transform objChild;
    private ConsistentVariables variables;
    private void Start()
    {
        objChild = gameObject.transform.GetChild(0);
        variables = GameObject.FindGameObjectWithTag("GameController").GetComponent<ConsistentVariables>();
    }

    void Update()
    {
        if (variables.lights == true)
        {
            objChild.gameObject.SetActive(false);
        }
        else
        {
            objChild.gameObject.SetActive(true);
        }
    }
}
