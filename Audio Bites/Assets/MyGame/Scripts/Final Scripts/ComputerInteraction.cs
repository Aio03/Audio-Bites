using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerInteraction : MonoBehaviour
{
    public GameObject offScreen;
    public GameObject onScreen;

    private ConsistentVariables variables;

    private void Start()
    {
        ///Finds the variables needed from the GameController
        variables = GameObject.FindGameObjectWithTag("GameController").GetComponent<ConsistentVariables>();
    }

    private void Update()
    {
        if (variables.computerIsOn == true)
        {
            offScreen.SetActive(false);
            onScreen.SetActive(true);
        }
        else
        {
            offScreen.SetActive(true);
            onScreen.SetActive(false);
        }
    }

}
