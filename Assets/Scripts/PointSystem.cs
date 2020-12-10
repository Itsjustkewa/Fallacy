using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Foolacy.Main
{ 
    public class PointSystem : MonoBehaviour
    {
        [SerializeField] private PointUI pointBar;

        public static PointSystem instance;

        private int Points;
        public int Revcieved;
        private int Target = 10;

        private float coin;

        [HideInInspector]
        public float check;

        [HideInInspector]
        public bool HasReached;

        private void Awake()
        {
            if(instance == null)
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

        // Start is called before the first frame update
        void Start()
        {
            Revcieved = Points;
            coin = Revcieved;
            pointBar.SetSize(coin);

        }

        // Update is called once per frame
        void Update()
        {
            Revcieved = Points;
            coin = Revcieved;
            PointChecker();
            pointBar.SetSize(check);
            //Reset();
            
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
                
                HasReached = true;
                
            }

        }

        public void PointChecker()
        {
            if (Points <= 0)
            {
                Points = 0;
            }
            if (10 <= Revcieved)
            {
                Points = 10;
                Reached();
            }
            Thinking();
        }

        public void Thinking()
        {
            check = (coin / 10.0f);
        }

        public void SavePoints()
        {
            PointSystem.instance.Revcieved = Revcieved;
        }

        public void Reset()
        {
                Points = 0;
                Revcieved = Points;
                Debug.Log("Is reset");

            if (Input.GetKeyDown(KeyCode.C))
            {

            }

        }
    }
}
