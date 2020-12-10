using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Foolacy.Main
{ 
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;

        [HideInInspector]public int recieved;
        [HideInInspector]public int collect;

        public GameObject PointCanvas;

        //public Roach QuestionCanvas;

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

            DontDestroyOnLoad(this);

            PointCanvas = GameObject.FindGameObjectWithTag("UI_Hud");

        }

        public void IsComplete()
        {
            pointSystem.PointChecker();
        }

        private void Update()
        {
            Trig();

        }

        public void PointCheck()
        {
            //gotten.Add(recieved);
            recieved = GameObject.FindGameObjectWithTag("PointController").GetComponent<Roach>().currentPoint;
            collect = recieved;
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
        public void Trig()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                BacktoGame();
                Debug.Log("button pressed");
            }
        }
        
    }
}