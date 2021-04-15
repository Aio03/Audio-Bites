using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Redundant script, unused
/// </summary>

public class Switch : MonoBehaviour
{    
    //This is a number representing when this switch should be pressed
    //First, second, third, etc
    [Header("Order Selection")]
    [Tooltip("what order is it this needs to be pressed")]
    public int orderId;
    public SwitchOrderValidator validator;

    public void SwitchPressed()
    {
        Debug.Log(name);
        validator.SwitchPressed(orderId);
    }
}
