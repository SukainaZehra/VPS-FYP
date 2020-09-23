using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using UnityEngine;

public enum ExamType { 
 palpation,
 percussion,
 auscultation,
 inspection
}

public class PhysicalExamMainUI : MonoBehaviour
{
    public List<PhysicalExamButton> examButtons;
    void Start()
    {
        for (int i = 0; i < examButtons.Count; i++)
        {
            examButtons[i].index = i;
            examButtons[i].callBack = OnExamButtonClick;
        }


    }
    void OnExamButtonClick(int Buttonindex) 
    {
        UnityEngine.Debug.Log("ButtonIndex="+Buttonindex); 
    }
}




