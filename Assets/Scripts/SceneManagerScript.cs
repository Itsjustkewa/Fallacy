using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Foolacy.Main
{
    public class SceneManagerScript : MonoBehaviour
    {
        public static SceneManagerScript instance;

        public GameObject gameManager;
        private int SceneToLoad;

        // Start is called before the first frame update
        void Awake()
        {
            //gameManager = ;
            //Application.LoadLevel(0);
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        public void EnterGame()
        {
          
            SceneManager.LoadScene(1);
            
        }

        public void ReloadLevel()
        {
            SceneManager.LoadScene(2);
        }

        public void StartQuestion()
        {
            //gameManager.BacktoGame();
            SceneManager.LoadScene(2);
            
        }


        


        
       
    }
}
