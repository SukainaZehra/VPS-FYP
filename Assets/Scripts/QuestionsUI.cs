using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class QuestionsUI : MonoBehaviour
{
    public GameObject buttonPrefab;
    public Transform buttonsContainer;
    public DataManager dataManager;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        var data = dataManager.vps.questions;
        for (int i=0; i<data.Count; i++)
        {
            var buttonClone = Instantiate(buttonPrefab,buttonsContainer,false);
            var buttonScript = buttonClone.GetComponent<QuestionButton>();
            buttonScript.questionText.text = data[i].question;
            buttonScript.index = i;
            buttonScript.questionsUI = this;
        }
        buttonPrefab.SetActive(false);
    }
    public void OnButtonEvent(int buttonID)
    {
        UnityEngine.Debug.Log(buttonID + " is clicked");
        audioSource.clip = dataManager.vps.questions[buttonID].answer;
        audioSource.Play();
    }

    
}
