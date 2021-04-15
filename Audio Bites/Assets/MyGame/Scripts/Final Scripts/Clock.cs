using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clock : MonoBehaviour
{
    [Range(0, 359)]
    public int countdownTime;
    public TMP_Text secondsText;
    public TMP_Text minutesText;
    int displaySeconds;
    int displayMinutes;

    public IEnumerator Countdown(int something)
    {
        while (countdownTime > 0)
        {
            yield return new WaitForSeconds(1f);
            countdownTime--;
        }
        yield return null;
    }

    private void Awake()
    {
        StartCoroutine(Countdown(countdownTime));
    }

    private void Update()
    {
        if (countdownTime < 60)
        {
            displaySeconds = countdownTime;
            displayMinutes = 0;
        }

        if (countdownTime >= 60 && countdownTime < 120)
        {
            displaySeconds = countdownTime - 60;
            displayMinutes = 1;
        }

        if (countdownTime >= 120 && countdownTime < 180)
        {
            displaySeconds = countdownTime - 120;
            displayMinutes = 2;
        }

        if (countdownTime >= 180 && countdownTime < 240)
        {
            displaySeconds = countdownTime - 180;
            displayMinutes = 3;
        }

        if (countdownTime >= 240 && countdownTime < 300)
        {
            displaySeconds = countdownTime - 240;
            displayMinutes = 4;
        }

        if (countdownTime >= 300 && countdownTime < 360)
        {
            displaySeconds = countdownTime - 300;
            displayMinutes = 5;
        }

        if (displaySeconds < 10)
        {
            secondsText.text = "0" + displaySeconds.ToString();
        }
        else
        {
            secondsText.text = displaySeconds.ToString();
        }
        
        minutesText.text = "0" + displayMinutes.ToString();

    }

}
