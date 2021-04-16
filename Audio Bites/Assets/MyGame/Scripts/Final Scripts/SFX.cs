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
        audioVariables.soundtrack_Midnight.Play();
    }
    public void PlayGremlinLaugh()
    {
        audioVariables.gremlinLaugh.Play();
    }
    public void PlayMouseClickHeavy()
    {
        audioVariables.mouseClickHeavy.Play();
    }
    public void PlayMouseClickLight()
    {
        audioVariables.mouseClickLight.Play();
    }
    public void PlaySoundtrackPuzzleOne()
    {
        audioVariables.soundtrack_PuzzleOne.Play();
    }
    public void PlaySoundtrackPuzzleTwo()
    {
        audioVariables.soundtrack_PuzzleTwo.Play();
    }
    public void PlaySoundtrackPuzzleThree()
    {
        audioVariables.soundtrack_PuzzleThree.Play();
    }
    public void PlaySwitchSoundOne()
    {
        audioVariables.switchSoundOne.Play();
    }
    public void PlaySwitchSoundTwo()
    {
        audioVariables.switchSoundTwo.Play();
    }
    public void PlayThunderClap()
    {
        if (staticSettings.loudNoises == false)
        {
            audioVariables.thunderClap.Play();
        }
    }

}
