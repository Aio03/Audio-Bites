using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This is a temporary script that calls for the gremlins to arrive as soon as the player changes the playback engine
/// It is temporary because there is no timer on it for added randomness
/// Will re-do later
/// </summary>

public class Temp_GremlinsArrive : MonoBehaviour
{
    ConsistentVariables variables;
    Kremidifier kremidifier;

    private void Start()
    {
        variables = GameObject.FindGameObjectWithTag("GameController").GetComponent<ConsistentVariables>();
        kremidifier = GameObject.FindGameObjectWithTag("GameController").GetComponent<Kremidifier>();
    }

    private void Update()
    {
        if (variables.haveGremlinsArrived == false)
        {
            if (variables.playbackEngine != 0)
            {
                Kremidify();
                variables.haveGremlinsArrived = true;
            }
        }
    }

    private void Kremidify()
    {
        kremidifier.activateCoroutine = true;
    }

}
