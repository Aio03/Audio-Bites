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
    bool switch_one;
    bool switch_two;
    bool switch_three;
    bool switch_four;
    bool correctOrder;

    private ConsistentVariables variables;

    private void Start()
    {
        ///Finds the variables needed from the GameController
        variables = GameObject.FindGameObjectWithTag("GameController").GetComponent<ConsistentVariables>();
    }

    private void Update()
    {
        //Checks if desk is on and nothing else for switch one
        if (variables.deskPower == true && variables.interfacePower == false && variables.computerPower == false && variables.speakerPower == false)
        {
            switch_one = true;
        }
        //Checks if desk and interface are on for switch two, if switch one hasn't been true then switch two can't be so it checks that as well
        if (variables.deskPower == true && variables.interfacePower == true && variables.computerPower == false && variables.speakerPower == false)
        {
            if (switch_one == true)
            {
                switch_two = true;
            }
        }
        //etc
        if (variables.deskPower == true && variables.interfacePower == true && variables.computerPower == true && variables.speakerPower == false)
        {
            if (switch_one == true && switch_two == true)
            {
                switch_three = true;
            }
        }
        //etc
        if (variables.deskPower == true && variables.interfacePower == true && variables.computerPower == true && variables.speakerPower == true)
        {
            if (switch_one == true && switch_two == true && switch_three == true)
            {
                switch_four = true;
            }
        }

        //If the relevant variable is turned off then the switch order cannot be true and resets it to false
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

        //Checks if all switches are true then the correct order is true
        if (switch_one == true && switch_two == true && switch_three == true && switch_four == true)
        {
            variables.switchesOrder = true;
        } 
        else
        {
            variables.switchesOrder = false;
        }

        //Similar to how the switches order is checked but done seperately so that grading can be done seperately for switch order and whether the system was reset
        if (variables.power == true && variables.deskPower == false && variables.interfacePower == false && variables.computerPower == false && variables.speakerPower == false)
        {
            variables.resetSystem = true;
        }

        if (variables.power == false)
        {
            variables.resetSystem = false;
        }

    }

}
