using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[System.Serializable]
public class Testie
{
    public string fallacyName;
    public enum fallacyType
    {
        adhominem,
        appealToAuthority,
        blackOrWhite,
        hastyGeneralization,
        slipperySlope,
        correlationCausation,
        anecdotalEvidence,
        loadedQuestion,
        poisoningTheWell,
        appealToEmotions
    }
    public fallacyType fallacies;
    public string fallacyAttribute;
}
   
        
