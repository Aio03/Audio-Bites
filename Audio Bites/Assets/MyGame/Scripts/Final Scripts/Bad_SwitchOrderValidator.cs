using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// THIS IS A BAD WAY TO CHECK IF THE SWITCHES ARE IN ORDER, ITS JUST SIMPLER THAN TRYING TO WRAP MY HEAD AROUND THE OTHER WAY
/// If I have time I will re-do this with the more concise code from the other group
/// 
/// This code checks whether the switches were switched in the correct order
/// 
/// still working on this
/// </summary>

public class Bad_SwitchOrderValidator : MonoBehaviour
{
    public bool switch_one;
    public bool switch_two;
    public bool switch_three;
    public bool switch_four;
    public bool correctOrder;

    private ConsistentVariables variables;

    private void Start()
    {
        ///Finds the variables needed from the GameController
        variables = GameObject.FindGameObjectWithTag("GameController").GetComponent<ConsistentVariables>();
    }

    private void Update()
    {
        if (variables.deskPower == true && variables.interfacePower == false && variables.computerPower == false && variables.speakerPower == false)
        {
            switch_one = true;
        }
        if (variables.deskPower == true && variables.interfacePower == true && variables.computerPower == false && variables.speakerPower == false)
        {
            if (switch_one == true)
            {
                switch_two = true;
            }
        }
        if (variables.deskPower == true && variables.interfacePower == true && variables.computerPower == true && variables.speakerPower == false)
        {
            if (switch_one == true && switch_two == true)
            {
                switch_three = true;
            }
        }
        if (variables.deskPower == true && variables.interfacePower == true && variables.computerPower == true && variables.speakerPower == true)
        {
            if (switch_one == true && switch_two == true && switch_three == true)
            {
                switch_four = true;
            }
        }

        if (variables.deskPower == false)
        {
            switch_one = false;
        }
        if (variables.interfacePower == false)
        {
            switch_two = false;
        }
        if (variables.computerPower == false)
        {
            switch_three = false;
        }
        if (variables.speakerPower == false)
        {
            switch_four = false;
        }

        if (switch_one == true && switch_two == true && switch_three == true && switch_four == true)
        {
            correctOrder = true;   
        } 
        else
        {
            correctOrder = false;
        }

    }

}
