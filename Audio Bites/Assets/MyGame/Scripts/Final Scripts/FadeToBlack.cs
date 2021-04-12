using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Fade in and out with the black square, default is fade to black.
/// https://turbofuture.com/graphic-design-video/How-to-Fade-to-Black-in-Unity for full understanding
/// </summary>

public class FadeToBlack : MonoBehaviour
{

    public GameObject blackOutSquare;

    public int fadingSpeed;
    public bool doneFading;

    private void Awake()
    {
        //Set transparency to 100%
        Color objectColor = blackOutSquare.GetComponent<Image>().color;
        objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, 1);
        blackOutSquare.GetComponent<Image>().color = objectColor;

        //Fade in when starting
        Fade(false, 3);
    }

    public void Fade(bool fadeTo, int speed)
    {
        print("Fade");
        StartCoroutine(FadeBlackOutSquare(fadeTo, speed));
    }

    public IEnumerator FadeBlackOutSquare(bool fadeToBlack = true, int fadeSpeed = 5)
    {
        doneFading = false;
        Color objectColor = blackOutSquare.GetComponent<Image>().color;
        float fadeAmount;

        if (fadeToBlack)
        {
            while (blackOutSquare.GetComponent<Image>().color.a < 1)
            {
                fadeAmount = objectColor.a + (fadeSpeed * Time.deltaTime);

                objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
                blackOutSquare.GetComponent<Image>().color = objectColor;
                yield return null;
            }
            if (blackOutSquare.GetComponent<Image>().color.a >= 1)
            {
                doneFading = true;
            }
        }
        else
        {
            while (blackOutSquare.GetComponent<Image>().color.a > 0)
            {
                fadeAmount = objectColor.a - (fadeSpeed * Time.deltaTime);

                objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
                blackOutSquare.GetComponent<Image>().color = objectColor;
                yield return null;
            }
        }
    }
}
