using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffLight : MonoBehaviour
{
    private Transform objChild;

    private void Start()
    {
        objChild = gameObject.transform.GetChild(0);
    }

    void Update()
    {
        if (UniversalVariables.lightSwitch == true)
        {
            objChild.gameObject.SetActive(false);
        } else
        {
            objChild.gameObject.SetActive(true);
        }
    }
}
