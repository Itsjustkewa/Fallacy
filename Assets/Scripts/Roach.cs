using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Foolacy.Main
{ 
    public class Roach : MonoBehaviour
    {
        public int recievedPoint;
        public int currentPoint;
        public int defaultPoint;

        private void Start()
        {
            recievedPoint = PointSystem.instance.Revcieved;
        }

        private void Update()
        {
            Updater();
        }


        public void Updater()
        {
            currentPoint = recievedPoint;
        }
    }
}