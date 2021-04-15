using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Redundant script, unused
/// </summary>

public class SwitchOrderValidator : MonoBehaviour
{
    public Switch[] switches;

    private List<int> switchesPressedOrder = new List<int>();

    public void SwitchPressed(int pointId)
    {
        switchesPressedOrder.Add(pointId);
    }

    //Call this when you want to validate the order of the switches
    public bool ValidateSwitchOrder()
    {
        //check that we have
        bool switchesInOrder = true;

        //check that we have pressed each switch, otherwise it can't possibly be in order
        if (switches.Length == switchesPressedOrder.Count)
        {
            for (int i = 1; i < switchesPressedOrder.Count; ++i)
            {
                if (switchesPressedOrder[i] != switches[i].orderId)
                {
                    switchesInOrder = false;
                    break;
                }
            }
        }
        else
        {
            switchesInOrder = false;
        }

        Debug.Log("Valid order: " + switchesInOrder);

        return switchesInOrder;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(2))
        {
            ValidateSwitchOrder();
        }
    }

}
