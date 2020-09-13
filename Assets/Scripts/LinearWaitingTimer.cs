using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LinearWaitingTimer : MonoBehaviour
{
    Image timerBar;
    public float maxTime = 5f;
    float timeLeft;
    public GameObject timerText;

    void Start()
    {
        timerBar = GetComponent<Image>();
        timeLeft = maxTime;
        timerText.SetActive(true);

    }

    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / maxTime;

        }
        else 
        {
            Time.timeScale = 0;
            timerText.SetActive(false);
        }
    }
}
