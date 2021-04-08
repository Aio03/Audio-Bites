using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// this just doesn't work right now...
/// </summary>
public class AppearWithPlaybackEngine : MonoBehaviour
{
    private GameObject playbackImage;
    public bool appearWhenPlaybackEngineEnabled = true;

    private void Start()
    {
        playbackImage = GameObject.Find("playbackImage");
        
    }

    private void Update()
    {
        if (playbackImage.activeInHierarchy == true)
        {
            this.gameObject.SetActive(appearWhenPlaybackEngineEnabled);
        } 
        else
        {
            this.gameObject.SetActive(!appearWhenPlaybackEngineEnabled);
        }
    }
}
