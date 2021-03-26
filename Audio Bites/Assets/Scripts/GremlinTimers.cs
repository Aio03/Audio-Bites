using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GremlinTimers : MonoBehaviour
{
    

    [Header("First Timer")]
    [Range(0, 120)]
    [Tooltip("in real-time seconds")]
    public float firstTimerMax;
    [Range(0, 120)]
    [Tooltip("in real-time seconds")]
    public float firstTimerMin;

    private float firstTimer;

    [Header("Second Timer")]
    [Range(0, 120)]
    [Tooltip("in real-time seconds")]
    public float secondTimerMax;
    [Range(0, 120)]
    [Tooltip("in real-time seconds")]
    public float secondTimerMin;

    private float secondTimer;

    private bool gremlinsHere;

    IEnumerator FirstTimerCoro(float Count)
    {
        yield return new WaitForSeconds(Count);

        yield return null;
    }
    private IEnumerator secondTimerCoro;

    private void Start()
    {
        if (UniversalVariables.haveTimersBeenSet == false)
        {
            firstTimer = Random.Range(firstTimerMin, firstTimerMax);
            secondTimer = Random.Range(secondTimerMin, secondTimerMax);
            StartCoroutine("FirstTimerCoro", firstTimer);
            UniversalVariables.haveTimersBeenSet = true;
        }
    }
}
