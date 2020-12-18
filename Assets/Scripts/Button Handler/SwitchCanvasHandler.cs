using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCanvasHandler : MonoBehaviour
{
    public GameObject startButton;
    public GameObject InstrButton;
    
    void Start()
    {
        startButton.SetActive(false);
    }

    public void Instr()
    {
        if (startButton.activeSelf)
        {
            startButton.SetActive(false);
            InstrButton.SetActive(true);
        }
        else
        {
            startButton.SetActive(true);
            InstrButton.SetActive(false);
        }
        
    }

    
}
