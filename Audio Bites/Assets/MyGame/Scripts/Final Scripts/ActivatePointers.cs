using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePointers : MonoBehaviour
{
    public GameObject[] pointers;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            EnablePointers();
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            DisablePointers();
        }
    }

    void DisablePointers()
    {
        for (int i = 0; i < pointers.Length; i++)
        {
            pointers[i].SetActive(false);
        }
    }

    void EnablePointers()
    {
        for (int i = 0; i < pointers.Length; i++)
        {
            if (pointers[i].transform.parent.gameObject.activeInHierarchy == true)
            {
                pointers[i].SetActive(true);
            }
        }
    }

}
