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

    private RandomiseOptions randomiseOptions;
    private ClickManager clickManager;

    IEnumerator FirstTimerCoro(float Count)
    {
        yield return new WaitForSeconds(Count);
        UniversalVariables.lightSwitch = false;
        clickManager.SceneChange("GB_FrontDesk");
        randomiseOptions.Randomise();
        StartCoroutine("SecondTimerCoro", secondTimer);
        yield return null;
    }

    IEnumerator SecondTimerCoro(float Count)
    {
        yield return new WaitForSeconds(Count);
        UniversalVariables.lightSwitch = false;
        clickManager.SceneChange("GB_FrontDesk");
        randomiseOptions.Randomise();
        secondTimer = Random.Range(secondTimerMin, secondTimerMax);
        StartCoroutine("SecondTimerCoro", secondTimer);
        yield return null;
    }

    private void Start()
    {
        if (UniversalVariables.haveTimersBeenSet == false)
        {
            firstTimer = Random.Range(firstTimerMin, firstTimerMax);
            secondTimer = Random.Range(secondTimerMin, secondTimerMax);
            StartCoroutine("FirstTimerCoro", firstTimer);
            UniversalVariables.haveTimersBeenSet = true;
        }

        randomiseOptions = GetComponentInParent<RandomiseOptions>();
        clickManager = GetComponentInParent<ClickManager>();

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            randomiseOptions.Randomise();
        }

    }

    private void OnEnable()
    {
        Debug.Log("Enabling", gameObject);
        print("how many times");
        firstTimer = Random.Range(firstTimerMin, firstTimerMax);
        StartCoroutine("FirstTimerCoro", firstTimer);
    }

}
