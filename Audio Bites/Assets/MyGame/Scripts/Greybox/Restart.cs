using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    
    Transform timersInstance;
    GremlinTimers gremlinTimers;
    bool timersActivated = true;

    private void Start()
    {
        timersInstance = this.gameObject.transform.GetChild(0);
        gremlinTimers = timersInstance.GetComponent<GremlinTimers>();
    }

    private void Update()
    {
        if (UniversalVariables.gradeScreen == true)
        {
            timersInstance.gameObject.SetActive(false);
            timersActivated = false;
        } else
        {
            timersInstance.gameObject.SetActive(true);
            if (timersActivated == false)
            {
                gremlinTimers.firstTimer = Random.Range(gremlinTimers.firstTimerMin, gremlinTimers.firstTimerMax);
                gremlinTimers.StartCoroutine("FirstTimerCoro", gremlinTimers.firstTimer);
                timersActivated = true;
            }
        }
    }

}
