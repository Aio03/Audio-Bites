using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{

    [SerializeField] private GameObject settingsMenu;

    private static MenuManager instance;
    public static MenuManager Instance { get { return instance; } }

    private void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }

    }

    public void TurnOnSettingsMenu()
    {
        settingsMenu.SetActive(true);
    }

    public void TurnOffSettingsMenu()
    {
        settingsMenu.SetActive(false);
    }

    public void TurnOnFrontDesk()
    {
        settingsMenu.SetActive(true);
    }

    public void TurnOffFrontDesk()
    {
        settingsMenu.SetActive(false);
    }

    public void TurnOnBackDesk()
    {
        settingsMenu.SetActive(true);
    }

    public void TurnOffBackDesk()
    {
        settingsMenu.SetActive(false);
    }

}
