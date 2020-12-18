using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Foolacy.Main
{ 
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;


        [Header("Canavas")]
        public GameObject PointCanvas;
        public GameObject testQuestion;
        public GameObject winCanvas;

        

        public PointSystem pointSystem;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(this);
                return;
            }

            //DontDestroyOnLoad(this);

            PointCanvas = GameObject.FindGameObjectWithTag("UI_Hud");

        }

        public void Start()
        {
            winCanvas.SetActive(false);
            
        }

        public void IsComplete()
        {
            pointSystem.PointChecker();
        }

        private void Update()
        {
            if(pointSystem.HasReached)
            {
                winCanvas.SetActive(true);
                PointCanvas.SetActive(false);
                testQuestion.SetActive(false);
                return;
            }

        }


        public void BackToMain()
        {
            pointSystem.Reset();
            if (PointCanvas.activeSelf)
            {
                PointCanvas.SetActive(false);

            }

        }
        public void BacktoGame()
        {
            if (!PointCanvas.activeSelf)
            {
                PointCanvas.SetActive(true);
                return;
            }
        }
        
    }
}