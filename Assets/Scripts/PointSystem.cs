using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Foolacy.Main
{ 
    public class PointSystem : MonoBehaviour
    {
        public int Points = 0 ;
        public int Revcieved;
        private int Target = 10;
        public bool HasReached;

        // Start is called before the first frame update
        void Start()
        {
           Revcieved = Points;
        }

        // Update is called once per frame
        void Update()
        {
            Revcieved = Points;
            PointChecker();

        }

        public void AddPoints(int plus)
        {
            plus = Points++;
            Revcieved = plus;
            
        }

        public void RemovePoints(int minus)
        {
            minus =  Points--;
            Revcieved = minus;
        }

        public void Reached()
        {
            if(Revcieved == Target)
            {
                Debug.Log("win");
                HasReached = true;
            }
            return;
            //else
            //{
            //    Debug.Log("keep trying");
            //}
        }

        public void PointChecker()
        {
            if(Points <= 0)
            {
                Points = 0;
            }
            if(Revcieved >= 10)
            {
                Revcieved = 10;
                
            }
            //Reached();
        }
    }
}
