using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    float currentTime = 0f;
    float startTime = 15f;

    [SerializeField] Text countdownText;

    public Text CountdownText { get => countdownText; set => countdownText = value; }

    void Start()
    {
        currentTime = startTime;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        if(currentTime < 10)
        {
            CountdownText.text = "00:0" + currentTime.ToString("0");
        }
        else
        {
            CountdownText.text = "00:" + currentTime.ToString("0");
        }
        

        if(currentTime <= 0)
        {
            currentTime = 0;
        }
    }

}
