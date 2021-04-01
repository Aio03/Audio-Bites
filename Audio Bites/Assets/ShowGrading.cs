using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowGrading : MonoBehaviour
{

    [Tooltip("This is the delay for each subsequent part of the grading to appear")]
    public float delay;

    IEnumerator ShowTheGrading(float Count)
    {
        if (UniversalVariables.resetSystemFirst == false)
        {
            yield return new WaitForSeconds(Count);
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            gameObject.transform.GetChild(13).gameObject.SetActive(true);
        } 
        else
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }

        
        if (UniversalVariables.c_Order_DICS == false)
        {
            yield return new WaitForSeconds(Count);
            gameObject.transform.GetChild(1).gameObject.SetActive(true);
            gameObject.transform.GetChild(13).gameObject.SetActive(true);
        }
        else
        {
            gameObject.transform.GetChild(1).gameObject.SetActive(false);
        }

        
        if (UniversalVariables.powerSwitch == false)
        {
            yield return new WaitForSeconds(Count);
            gameObject.transform.GetChild(2).gameObject.SetActive(true);
            gameObject.transform.GetChild(13).gameObject.SetActive(true);
        }
        else
        {
            gameObject.transform.GetChild(2).gameObject.SetActive(false);
        }

        
        if (UniversalVariables.deskSwitch == false)
        {
            yield return new WaitForSeconds(Count);
            gameObject.transform.GetChild(3).gameObject.SetActive(true);
            gameObject.transform.GetChild(13).gameObject.SetActive(true);
        }
        else
        {
            gameObject.transform.GetChild(3).gameObject.SetActive(false);
        }

        
        if (UniversalVariables.interfaceSwitch == false)
        {
            yield return new WaitForSeconds(Count);
            gameObject.transform.GetChild(4).gameObject.SetActive(true);
            gameObject.transform.GetChild(13).gameObject.SetActive(true);
        }
        else
        {
            gameObject.transform.GetChild(4).gameObject.SetActive(false);
        }

        
        if (UniversalVariables.computerSwitch == false)
        {
            yield return new WaitForSeconds(Count);
            gameObject.transform.GetChild(5).gameObject.SetActive(true);
            gameObject.transform.GetChild(13).gameObject.SetActive(true);
        }
        else
        {
            gameObject.transform.GetChild(5).gameObject.SetActive(false);
        }

        
        if (UniversalVariables.speakersSwitch == false)
        {
            yield return new WaitForSeconds(Count);
            gameObject.transform.GetChild(6).gameObject.SetActive(true);
            gameObject.transform.GetChild(13).gameObject.SetActive(true);
        }
        else
        {
            gameObject.transform.GetChild(6).gameObject.SetActive(false);
        }

        
        if (UniversalVariables.playbackEngineDropdown != 4)
        {
            yield return new WaitForSeconds(Count);
            gameObject.transform.GetChild(7).gameObject.SetActive(true);
            gameObject.transform.GetChild(13).gameObject.SetActive(true);
        }
        else
        {
            gameObject.transform.GetChild(7).gameObject.SetActive(false);
        }

        
        if (UniversalVariables.bufferDropdown != 0)
        {
            yield return new WaitForSeconds(Count);
            gameObject.transform.GetChild(8).gameObject.SetActive(true);
            gameObject.transform.GetChild(13).gameObject.SetActive(true);
        }
        else
        {
            gameObject.transform.GetChild(8).gameObject.SetActive(false);
        }

        
        if (UniversalVariables.ignoreErrors == false)
        {
            yield return new WaitForSeconds(Count);
            gameObject.transform.GetChild(9).gameObject.SetActive(true);
            gameObject.transform.GetChild(13).gameObject.SetActive(true);
        }
        else
        {
            gameObject.transform.GetChild(9).gameObject.SetActive(false);
        }

        
        if (UniversalVariables.dynamicProcessing == true)
        {
            yield return new WaitForSeconds(Count);
            gameObject.transform.GetChild(10).gameObject.SetActive(true);
            gameObject.transform.GetChild(13).gameObject.SetActive(true);
        }
        else
        {
            gameObject.transform.GetChild(10).gameObject.SetActive(false);
        }

        
        if (UniversalVariables.videoEngine == true)
        {
            yield return new WaitForSeconds(Count);
            gameObject.transform.GetChild(11).gameObject.SetActive(true);
            gameObject.transform.GetChild(13).gameObject.SetActive(true);
        }
        else
        {
            gameObject.transform.GetChild(11).gameObject.SetActive(false);
        }

        
        if (UniversalVariables.cacheSizeDropdown != 0)
        {
            yield return new WaitForSeconds(Count);
            gameObject.transform.GetChild(12).gameObject.SetActive(true);
            gameObject.transform.GetChild(13).gameObject.SetActive(true);
        }
        else
        {
            gameObject.transform.GetChild(12).gameObject.SetActive(false);
        }

        yield return null;
    }

    private void Update()
    {
        print("this is running");
        StartCoroutine("ShowTheGrading", delay);
    }

    ///children:
    ///0 - Reset system
    ///1 - Switch order
    ///2 - Power
    ///3 - Desk
    ///4 - Interface
    ///5 - Computer
    ///6 - Speakers
    ///7 - Playback Engine
    ///8 - Buffer Size
    ///9 - Ignore Errors
    ///10 - Dynamic Processing
    ///11 - Video Engine
    ///12 - Cache Size
    ///13 - This is bad because...



}
