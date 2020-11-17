using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;


namespace Foolacy.Main.Questions
{
    public class CanvasManager : MonoBehaviour
    {
        public GameObject Main;
        public GameObject Question;

        //public Canvas View;

        //public GameObject BackBT;



        // Start is called before the first frame update
        void Awake()
        {
            Question.SetActive(false);
            Main.SetActive(true);
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void GoToMain()
        {
             Main.SetActive(true);
             Question.SetActive(false);
               
            
        }

        public void GoToQuestion()
        {
            Question.SetActive(true);
            Main.SetActive(false);
        }

        void DisableCanvas()
        {

            //BackBT.SetActive(false);
        }
    }
}
