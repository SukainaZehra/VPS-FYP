using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PhysicalExamButton : MonoBehaviour
{
    public ExamType examType;
    public int index;
    public int score;
    public Action<int> callBack;
    public void OnExamButtonClick() 
    {
        callBack?.Invoke(index);
    }
}
