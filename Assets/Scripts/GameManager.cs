using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Foolacy.Main
{ 
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;

        

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

    }
}