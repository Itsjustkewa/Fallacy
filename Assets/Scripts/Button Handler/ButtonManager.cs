using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Foolacy.Main
{
    public class ButtonManager : MonoBehaviour
    {
        public GameObject gameQst;

        private int Point;

        [SerializeField] private PointSystem points;

        public void FindOpts(int xvalue)
        {
            gameQst = GameObject.FindGameObjectWithTag("Questions");
            var chosen = gameQst.GetComponent<Roach>().currentQuiz.Options[xvalue];
            var correct = gameQst.GetComponent<Roach>().currentQuiz.correct;

            if(chosen == correct)
            {
                //print("Goodie");
                points.AddPoints(Point);
                points.Reached();
                gameQst.GetComponent<Roach>().control();
                return;
            }
            else
            {
                //print("Baddie");
                points.RemovePoints(Point);
                points.Reached();
                gameQst.GetComponent<Roach>().control();
                return;
            }


        }
    }
}

