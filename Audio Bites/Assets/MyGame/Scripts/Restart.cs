using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    
    Transform timersInstance;

    private void Start()
    {
        timersInstance = this.gameObject.transform.GetChild(0);
    }

    private void Update()
    {
        if (UniversalVariables.gradeScreen == true)
        {
            timersInstance.gameObject.SetActive(false);
        } else
        {
            timersInstance.gameObject.SetActive(true);
        }
    }

}
