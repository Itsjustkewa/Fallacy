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
        private int SceneToLoad;


        public void EnterGame()
        {
          
            SceneManager.LoadScene(1);
            
        }

        public void ReloadLevel()
        {
            SceneManager.LoadScene(2);
        }

        public void GoHome()
        {
            
            SceneManager.LoadScene(0);
            
        }


        


        
       
    }
}
