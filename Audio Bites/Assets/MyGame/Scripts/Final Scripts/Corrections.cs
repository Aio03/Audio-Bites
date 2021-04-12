using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// To go on the corrections UI object, handles spawning the relevant corrections and
/// 
/// The values for x and y placement are wrong, plus size seems to be an issue when instantiating, and font size... Everything basically...
/// </summary>

public class Corrections : MonoBehaviour
{
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

        x_placement = -124;
        y_placement = 175;

        if (variables.resetSystem == false)
        {
            GameObject obj = Instantiate(noReset) as GameObject;
            obj.transform.SetParent(this.gameObject.transform);

            var m_RectTransform = obj.GetComponent<RectTransform>();
            m_RectTransform.anchoredPosition = new Vector2(x_placement, y_placement);

            y_placement = y_placement - 35;
        }
        if (variables.switchesOrder == false)
        {
            GameObject obj = Instantiate(wrongOrder) as GameObject;
            obj.transform.SetParent(this.gameObject.transform);
            var m_RectTransform = obj.GetComponent<RectTransform>();
            m_RectTransform.anchoredPosition = new Vector2(x_placement, y_placement);
            y_placement = y_placement - 35;
        }
        if (variables.power == false)
        {
            GameObject obj = Instantiate(noMainPower) as GameObject;
            obj.transform.SetParent(this.gameObject.transform);
            var m_RectTransform = obj.GetComponent<RectTransform>();
            m_RectTransform.anchoredPosition = new Vector2(x_placement, y_placement);
            y_placement = y_placement - 35;
        }
        if (variables.deskPower == false)
        {
            GameObject obj = Instantiate(noDesk) as GameObject;
            obj.transform.SetParent(this.gameObject.transform);
            var m_RectTransform = obj.GetComponent<RectTransform>();
            m_RectTransform.anchoredPosition = new Vector2(x_placement, y_placement);
            y_placement = y_placement - 35;
        }
        if (variables.interfacePower == false)
        {
            GameObject obj = Instantiate(noInterface) as GameObject;
            obj.transform.SetParent(this.gameObject.transform);
            var m_RectTransform = obj.GetComponent<RectTransform>();
            m_RectTransform.anchoredPosition = new Vector2(x_placement, y_placement);
            y_placement = y_placement - 35;
        }
        if (y_placement == -35 && x_placement == -124)
        {
            y_placement = 175;
            x_placement = 120;
        }
        if (variables.computerPower == false)
        {
            GameObject obj = Instantiate(noComputer) as GameObject;
            obj.transform.SetParent(this.gameObject.transform);
            var m_RectTransform = obj.GetComponent<RectTransform>();
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
            GameObject obj = Instantiate(noSpeakers) as GameObject;
            obj.transform.SetParent(this.gameObject.transform);
            var m_RectTransform = obj.GetComponent<RectTransform>();
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
            GameObject obj = Instantiate(wrongPlaybackEngine) as GameObject;
            obj.transform.SetParent(this.gameObject.transform);
            var m_RectTransform = obj.GetComponent<RectTransform>();
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
            GameObject obj = Instantiate(wrongBufferSize) as GameObject;
            obj.transform.SetParent(this.gameObject.transform);
            var m_RectTransform = obj.GetComponent<RectTransform>();
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
            GameObject obj = Instantiate(wrongIgnoreErrors) as GameObject;
            obj.transform.SetParent(this.gameObject.transform);
            var m_RectTransform = obj.GetComponent<RectTransform>();
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
            GameObject obj = Instantiate(wrongDynamicProcessing) as GameObject;
            obj.transform.SetParent(this.gameObject.transform);
            var m_RectTransform = obj.GetComponent<RectTransform>();
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
            GameObject obj = Instantiate(wrongVideoEngine) as GameObject;
            obj.transform.SetParent(this.gameObject.transform);
            var m_RectTransform = obj.GetComponent<RectTransform>();
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
            GameObject obj = Instantiate(wrongCacheSize) as GameObject;
            obj.transform.SetParent(this.gameObject.transform);
            var m_RectTransform = obj.GetComponent<RectTransform>();
            m_RectTransform.anchoredPosition = new Vector2(x_placement, y_placement);
            y_placement = y_placement - 35;
        }
    }



}
