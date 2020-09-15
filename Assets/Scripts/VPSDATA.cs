using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/VPSDataScriptableObject", order = 1)]
public class VPSDATA : ScriptableObject
{

    public List<VPSQuestion> questions;

    
}

[System.Serializable]
public class VPSQuestion
{
    public string question;
    public AudioClip answer; 
}