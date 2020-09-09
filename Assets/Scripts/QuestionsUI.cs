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
    private VPSProgress vpsProgress;
    // Start is called before the first frame update
    void Start()
    {
        vpsProgress = new VPSProgress(); //object where we will store the progress
        var data = dataManager.vps.questions;
        for (int i=0; i<data.Count; i++)
        {
            var buttonClone = Instantiate(buttonPrefab,buttonsContainer,false);
            var buttonScript = buttonClone.GetComponent<QuestionButton>();
            buttonScript.questionText.text = data[i].question;
            buttonScript.index = i;
            buttonScript.questionsUI = this;
            vpsProgress.progress.Add(new QsProgress() { questionId = i }); 
        }
        buttonPrefab.SetActive(false);
    }
    public void OnButtonEvent(int buttonID)
    {
        for (int i = 0; i < vpsProgress.progress.Count; i++)
        {
            if (vpsProgress.progress[i].questionId == buttonID)
            {
                vpsProgress.progress[i].attemptStatus = true;
                vpsProgress.progress[i].marks += 1;
            }
        }
        UnityEngine.Debug.Log(buttonID + " is clicked");
        audioSource.clip = dataManager.vps.questions[buttonID].answer;
        audioSource.Play();
        UnityEngine.Debug.Log(JsonUtility.ToJson(vpsProgress));
    }

    
}
