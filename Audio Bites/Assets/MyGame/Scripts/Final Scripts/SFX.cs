using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Handles all the sound effects in game
/// 
/// To make a sound put in the relevant script:
/// 
///     GameObject manager;
///     Destruction_SFX soundEffects;
///     
///     void Awake ()
///     {
///         manager = GameObject.Find("Manager");
///         soundEffects = manager.GetComponent<SFX>();
///     }
///     
///     "Where you want the sound to be activated"
///     {
///         soundEffects.PlaySoundName();
///     }
///
/// </summary>

public class SFX : MonoBehaviour
{
    //public AudioSource name;

    //public void PlaySoundName()
    //{
    //    name.Play();
    //}

    Audio audioVariables;

    private void Start()
    {
        audioVariables = GameObject.FindGameObjectWithTag("AudioVariables").GetComponent<Audio>();
    }

    public void PlaySoundTrackMidnight()
    {
        if (StaticSettings.music == true)
        {
            audioVariables.soundtrack_Midnight.Play();
        }
    }
    public void PlayGremlinLaugh()
    {
        if (StaticSettings.soundEffects == true)
        {
            audioVariables.gremlinLaugh.Play();
        }
    }
    public void PlayMouseClickHeavy()
    {
        if (StaticSettings.soundEffects == true)
        {
            audioVariables.mouseClickHeavy.Play();
        }
    }
    public void PlayMouseClickLight()
    {
        if (StaticSettings.soundEffects == true)
        {
            audioVariables.mouseClickLight.Play();
        }
    }
    public void PlaySoundtrackPuzzleOne()
    {
        if (StaticSettings.music == true)
        {
            audioVariables.soundtrack_PuzzleOne.Play();
        }
    }
    public void PlaySoundtrackPuzzleTwo()
    {
        if (StaticSettings.music == true)
        {
            audioVariables.soundtrack_PuzzleTwo.Play();
        }
    }
    public void PlaySoundtrackPuzzleThree()
    {
        if (StaticSettings.music == true)
        {
            audioVariables.soundtrack_PuzzleThree.Play();
        }
    }
    public void PlaySwitchSoundOne()
    {
        if (StaticSettings.soundEffects == true)
        {
            audioVariables.switchSoundOne.Play();
        }
    }
    public void PlaySwitchSoundTwo()
    {
        if (StaticSettings.soundEffects == true)
        {
            audioVariables.switchSoundTwo.Play();
        }
    }
    public void PlayThunderClap()
    {
        if (StaticSettings.loudNoises == true && StaticSettings.soundEffects == true)
        {
            audioVariables.thunderClap.Play();
        }
    }
    public void PlaySuctionHoodButton()
    {
        if (StaticSettings.soundEffects == true)
        {
            audioVariables.suctionHoodButton.Play();
        }
    }

}
