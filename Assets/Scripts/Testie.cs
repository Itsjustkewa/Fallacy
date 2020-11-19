using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Foolacy.Main { 

    public class Testie : MonoBehaviour
    {

        [SerializeField] PointUI pointShow;



        // Start is called before the first frame update
        void Start()
        {
            pointShow.SetSize(.3f);
        }

       
    }
        
}