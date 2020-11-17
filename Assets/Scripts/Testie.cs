using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Foolacy.Main { 

    public class Testie : MonoBehaviour
    {

        public GameObject GRead;
        public GameObject GLearn;
        public int Point; 

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            Itsjustkewa();
            
        }

        public void Itsjustkewa()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log(Point);
                
            }

            if (Input.GetMouseButtonDown(1))
            {
                Check();

            }
        }


        public void Check()
        {
            if (GRead == GLearn)
                Dabira();
        }
                
                    
        

        public void Dabira()
        {
            Point++;
            
        }
    }
        
}