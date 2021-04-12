using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/// <summary>
/// To go on the corrections UI object, handles spawning the relevant corrections and
/// 
/// </summary>

public class Corrections : MonoBehaviour
{
    //Corrections Spawn Location Variables
    private float x_placement;
    private float y_placement;

    //Text Game Objects
    [Header("Button Game Object Prefabs")]
    public GameObject noReset;
    public GameObject wrongOrder;
    public GameObject noMainPower;
    public GameObject noDesk;
    public GameObject noInterface;
    public GameObject noComputer;
    public GameObject noSpeakers;
    public GameObject wrongPlaybackEngine;
    public GameObject wrongBufferSize;
    public GameObject wrongIgnoreErrors;
    public GameObject wrongDynamicProcessing;
    public GameObject wrongVideoEngine;
    public GameObject wrongCacheSize;

    private ConsistentVariables variables;

    private void Start()
    {
        ///Finds the variables needed from the GameController
        variables = GameObject.FindGameObjectWithTag("GameController").GetComponent<ConsistentVariables>();

        //Sets the starting location for instantiating corrections
        x_placement = -124;
        y_placement = 175;

        //Checks if the relevant variable is incorrect from what we want
        if (variables.resetSystem == false)
        {
            //Makes a temporary variable of the RectTransform of the relevant object (affects size, location and etc of the component we are using in the UI, since the buttons are a UI element a normal transform change doesn't work since it is tied to the camera)
            var m_RectTransform = noReset.GetComponent<RectTransform>();
            //Sets the anchored position of the element, this sets the position in world space rather than in relation to its parent canvas
            m_RectTransform.anchoredPosition = new Vector2(x_placement, y_placement);
            //Lowers the y position for the next correction to spawn
            y_placement = y_placement - 35;
        }
        //The same process is done for each but with the relevant prefab and variables in place, I'm not sure if there is a less code heavy way to do this (I bet someone will say an array or something)
        if (variables.switchesOrder == false)
        {
            var m_RectTransform = wrongOrder.GetComponent<RectTransform>();
            m_RectTransform.anchoredPosition = new Vector2(x_placement, y_placement);
            y_placement = y_placement - 35;
        }
        if (variables.power == false)
        {
            var m_RectTransform = noMainPower.GetComponent<RectTransform>();
            m_RectTransform.anchoredPosition = new Vector2(x_placement, y_placement);
            y_placement = y_placement - 35;
        }
        if (variables.deskPower == false)
        {
            var m_RectTransform = noDesk.GetComponent<RectTransform>();
            m_RectTransform.anchoredPosition = new Vector2(x_placement, y_placement);
            y_placement = y_placement - 35;
        }
        if (variables.interfacePower == false)
        {
            var m_RectTransform = noInterface.GetComponent<RectTransform>();
            m_RectTransform.anchoredPosition = new Vector2(x_placement, y_placement);
            y_placement = y_placement - 35;
        }
        //Checks if the placement has reached the bottom of the relevant area, if so it will reset the y coordinate and move the x coordinate over to the right somewhat
        if (y_placement == -35 && x_placement == -124)
        {
            y_placement = 175;
            x_placement = 120;
        }
        if (variables.computerPower == false)
        {
            var m_RectTransform = noComputer.GetComponent<RectTransform>();
            m_RectTransform.anchoredPosition = new Vector2(x_placement, y_placement);
            y_placement = y_placement - 35;
        }
        if (y_placement == -35 && x_placement == -124)
        {
            y_placement = 175;
            x_placement = 120;
        }
        if (variables.bothSpeakers == false)
        {
            var m_RectTransform = noSpeakers.GetComponent<RectTransform>();
            m_RectTransform.anchoredPosition = new Vector2(x_placement, y_placement);
            y_placement = y_placement - 35;
        }
        if (y_placement == -35 && x_placement == -124)
        {
            y_placement = 175;
            x_placement = 120;
        }
        if (variables.playbackEngine != 4)
        {
            var m_RectTransform = wrongPlaybackEngine.GetComponent<RectTransform>();
            m_RectTransform.anchoredPosition = new Vector2(x_placement, y_placement);
            y_placement = y_placement - 35;
        }
        if (y_placement == -35 && x_placement == -124)
        {
            y_placement = 175;
            x_placement = 120;
        }
        if (variables.bufferSize != variables.wantedBufferSize)
        {
            var m_RectTransform = wrongBufferSize.GetComponent<RectTransform>();
            m_RectTransform.anchoredPosition = new Vector2(x_placement, y_placement);
            y_placement = y_placement - 35;
        }
        if (y_placement == -35 && x_placement == -124)
        {
            y_placement = 175;
            x_placement = 120;
        }
        if (variables.ignoreErrors != variables.wantedIgnoreErrors)
        {
            var m_RectTransform = wrongIgnoreErrors.GetComponent<RectTransform>();
            m_RectTransform.anchoredPosition = new Vector2(x_placement, y_placement);
            y_placement = y_placement - 35;
        }
        if (y_placement == -35 && x_placement == -124)
        {
            y_placement = 175;
            x_placement = 120;
        }
        if (variables.dynamic != variables.wantedDynamicProcessing)
        {
            var m_RectTransform = wrongDynamicProcessing.GetComponent<RectTransform>();
            m_RectTransform.anchoredPosition = new Vector2(x_placement, y_placement);
            y_placement = y_placement - 35;
        }
        if (y_placement == -35 && x_placement == -124)
        {
            y_placement = 175;
            x_placement = 120;
        }
        if (variables.videoEngine == true)
        {
            var m_RectTransform = wrongVideoEngine.GetComponent<RectTransform>();
            m_RectTransform.anchoredPosition = new Vector2(x_placement, y_placement);
            y_placement = y_placement - 35;
        }
        if (y_placement == -35 && x_placement == -124)
        {
            y_placement = 175;
            x_placement = 120;
        }
        if (variables.cacheSize != 0)
        {
            var m_RectTransform = wrongCacheSize.GetComponent<RectTransform>();
            m_RectTransform.anchoredPosition = new Vector2(x_placement, y_placement);
            y_placement = y_placement - 35;
        }
    }

    //Text/Information Variables
    private GameObject informationText;
    private TextMeshProUGUI textElement;

    //Text Information
    [Header("Correction Information")]
    [TextArea(3, 5)]
    public string noResetInfo;
    [TextArea(3, 5)]
    public string wrongOrderInfo;
    [TextArea(3, 5)]
    public string noMainPowerInfo;
    [TextArea(3, 5)]
    public string noDeskInfo;
    [TextArea(3, 5)]
    public string noInterfaceInfo;
    [TextArea(3, 5)]
    public string noComputerInfo;
    [TextArea(3, 5)]
    public string noSpeakersInfo;
    [TextArea(3, 5)]
    public string wrongPlaybackEngineInfo;
    [TextArea(3, 5)]
    public string wrongBufferSizeInfo;
    [TextArea(3, 5)]
    public string wrongIgnoreErrorsInfo;
    [TextArea(3, 5)]
    public string wrongDynamicProcessingInfo;
    [TextArea(3, 5)]
    public string wrongVideoEngineInfo;
    [TextArea(3, 5)]
    public string wrongCacheSizeInfo;


    private void Awake()
    {
        //Finds the relevant hover text element (which is attached the the Main Camera Prefab in its children)
        informationText = GameObject.Find("InfoText");
        textElement = informationText.GetComponent<TextMeshProUGUI>();
        //Removes text element text when awake
        textElement.text = "";
    }

    public void ShowNoResetInfo()
    {
        textElement.text = noResetInfo;
    }
    public void ShowWrongOrderInfo()
    {
        textElement.text = wrongOrderInfo;
    }
    public void ShowNoMainPowerInfo()
    {
        textElement.text = noMainPowerInfo;
    }
    public void ShowNoDeskInfo()
    {
        textElement.text = noDeskInfo;
    }
    public void ShowNoInterfaceInfo()
    {
        textElement.text = noInterfaceInfo;
    }
    public void ShowNoComputerInfo()
    {
        textElement.text = noComputerInfo;
    }
    public void ShowSpeakersInfo()
    {
        textElement.text = noSpeakersInfo;
    }
    public void ShowWrongPlaybackEngineInfo()
    {
        textElement.text = wrongPlaybackEngineInfo;
    }
    public void ShowWrongBufferSizeInfo()
    {
        textElement.text = wrongBufferSizeInfo;
    }
    public void ShowWrongIgnoreErrorsInfo()
    {
        textElement.text = wrongIgnoreErrorsInfo;
    }
    public void ShowWrongDynamicProcessingInfo()
    {
        textElement.text = wrongDynamicProcessingInfo;
    }
    public void ShowWrongVideoEngineInfo()
    {
        textElement.text = wrongVideoEngineInfo;
    }
    public void ShowWrongCacheSizeInfo()
    {
        textElement.text = wrongCacheSizeInfo;
    }
}
