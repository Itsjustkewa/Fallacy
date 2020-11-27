using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Foolacy.Main
{
    public class SceneManager : MonoBehaviour
    {
        public static SceneManager instance; 
        private int SceneToLoad;

        // Start is called before the first frame update
        void Start()
        {
            //Application.LoadLevel(0);
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        public void EnterGame()
        {
            Application.LoadLevel(1);
        }

        public void NextQuestion()
        {
            Application.LoadLevel(2);
        }

        public void StartQuestion()
        {
            Application.LoadLevel(2);
        }


        


        
       
    }
}
