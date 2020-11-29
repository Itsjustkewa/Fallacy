using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Foolacy.Main
{ 
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;

        public int recieved;
        public int checkPoint;
        public int pointUI;
        public int collect;
        //public Roach QuestionCanvas;

        public PointSystem Complete;

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

        }

        public void IsComplete()
        {
            Complete.PointChecker();
        }

        private void Update()
        {
            recieved = GameObject.FindGameObjectWithTag("PointController").GetComponent<Roach>().currentPoint;
            Checks();
           
        }

        public void Checks()
        {
            //collect = recieved;
            //pointUI = collect + recieved;
            
        }
    }
}