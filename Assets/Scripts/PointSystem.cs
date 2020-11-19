using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Foolacy.Main
{ 
    public class PointSystem : MonoBehaviour
    {
        [SerializeField] private PointUI pointBar;

        public int Points;
        public int Revcieved;
        private int Target = 10;
        public bool HasReached;

        public float coin;
        public float check;
      

        // Start is called before the first frame update
        void Start()
        {
            Revcieved = Points;
            pointBar.SetSize(coin);
            coin = Revcieved;
            
        }

        // Update is called once per frame
        void Update()
        {
            Revcieved = Points;
            coin = Revcieved;
            pointBar.SetSize(check);
            
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

        }

        public void PointChecker()
        {
            if(Points <= 0)
            {
                Points = 0;
            }
            if(Revcieved == 10)
            {
                Revcieved = 10;
                Reached();
            }
            Thinking();
        }

        public void Thinking()
        {
            if(Revcieved <= 0.1)
            {
                //check = coin;
            }
            else
            {
                 check = (coin / 10.0f);

            }
        }
    }
}
