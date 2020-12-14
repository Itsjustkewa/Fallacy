using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Events;
//using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Linq;

namespace Foolacy.Main
{ 
    public class Roach : MonoBehaviour
    {
        public Testie[] testie;

        [Header("Questions")]
        public Bug[] quiz;
        private List<Bug> unansweredtest;
        private List<Testie> lureOpts;
        private Bug currentQuiz;
        private Testie lure;
        private int score;

        private List<Bug> options = new List<Bug>();

        [Header("Settings")]
        
        [SerializeField]private PointSystem tally;
        [SerializeField]private Text QuestionText;
        [SerializeField]private Text option1;
        [SerializeField]private Text option2;
        [SerializeField]private List<int> answerOrder = new List<int>(new int[] { 1, 2 });

        private void Start()
        {
            if(unansweredtest == null || unansweredtest.Count==0)
            {
                unansweredtest = quiz.ToList<Bug>();
            }
            if(lureOpts == null || lureOpts.Count == 0)
            {
                lureOpts = testie.ToList<Testie>();
            }
            RunSim();
            Trap();
        }

        private void Update()
        {
            control();
        }

        private void RunSim()
        {
            //if(unansweredtest.Count <= 0)
            //{
            //    unansweredtest.Add(quiz);
            //}
            int randomBugIndex = Random.Range(0, unansweredtest.Count);
            currentQuiz = unansweredtest[randomBugIndex];
            QuestionText.text = currentQuiz.Questions;
            option1.text = currentQuiz.Options;
            //option1.text = answerOrder.ToString():

        }
        public void Trap()
        {
            int randomTestieIndex = Random.Range(0,lureOpts.Count);
            lure = lureOpts[randomTestieIndex];
            option2.text = lure.fallacyName;

        }

        IEnumerator NeHex()
        {
            unansweredtest.Remove(currentQuiz);

            yield return new WaitForSeconds(1);
            RunSim();
            Trap();
            Shuffle(answerOrder);
            
        }

        public void Correct()
        {
            switch (currentQuiz.type)
            {
                case Testie.fallacyType.adhominem:
                    //print("jop");
                    tally.AddPoints(score);
                    break;
                case Testie.fallacyType.anecdotalEvidence:
                    //print("none");
                    tally.AddPoints(score);
                    break;
                case Testie.fallacyType.appealToAuthority:
                    //print("cheese");
                    tally.AddPoints(score);
                    break;
                case Testie.fallacyType.blackOrWhite:
                    //print("reach");
                    tally.AddPoints(score);
                    break;
                case Testie.fallacyType.correlationCausation:
                    //print("touch");
                    tally.AddPoints(score);
                    break;
                case Testie.fallacyType.hastyGeneralization:
                    //print("solad");
                    tally.AddPoints(score);
                    break;
                case Testie.fallacyType.loadedQuestion:
                    //print("butt");
                    tally.AddPoints(score);
                    break;
                case Testie.fallacyType.poisoningTheWell:
                    //print("lol");
                    tally.AddPoints(score);
                    break;
                case Testie.fallacyType.slipperySlope:
                    //print("curse");
                    tally.AddPoints(score);
                    break;
                default:
                    print("No credit today");
                    tally.RemovePoints(score);
                    break;

            }
            AnswerHandler(answerOrder[1]);
            StartCoroutine(NeHex());
        }
        public void Wrong()
        {
            tally.RemovePoints(score);
            StartCoroutine(NeHex());
            
        }

        public void control()
        {
           if(currentQuiz.type == lure.fallacies)
            {
                Trap();
            }
        }

        public void AnswerHandler(int answer)
        {
            if(answer == 1)
            {
                print("rush");
            }
        }

        //created the shuffle funtion thanks to stackoverflow.com/questions/273313/randomize-a-listt-in-c-sharp
        static readonly System.Random rng = new System.Random();
        public static void Shuffle<X>(IList<X> list)
        {
            int n = list.Count;
            while(n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                X value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}