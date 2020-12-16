using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Events;
//using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Linq;
using System;


namespace Foolacy.Main
{ 
    public class Roach : MonoBehaviour
    {
        public Testie[] testie;

        [Header("Questions")]
        public Bug[] quiz;
        private List<Bug> unansweredtest;
        private List<Testie> lureOpts;
        private Bug currentQuiz= new Bug();
        private Testie lure;
        private int score;

        //private List<Bug> options = new List<Bug>();

        [Header("Settings")]
        
        [SerializeField]private PointSystem tally;
        [SerializeField]private Text QuestionText;
        [SerializeField]private Text option1;
        [SerializeField]private Text option2;

        [Header("Answer")]
        public int optionCount;


        private void Awake()
        {
           
        }


        private void Start()
        {
            if(unansweredtest == null || unansweredtest.Count==0)
            {
                unansweredtest = quiz.ToList<Bug>();
            }
            RunSim();
            //Correct();
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

            int randomBugIndex = UnityEngine.Random.Range(0, unansweredtest.Count);
            currentQuiz = unansweredtest[randomBugIndex];
            QuestionText.text = currentQuiz.Questions;



            

            List<Testie.FallacyType> tempList = new List<Testie.FallacyType>(new Testie.FallacyType[9]);
            tempList = currentQuiz.Options;
            //currentQuiz.OptGen(optionCount);

            int currentindex;
            currentindex = currentQuiz.Options.Capacity;

            var fristOpt = currentQuiz.Options[0];
            var secondOpt = currentQuiz.Options[1];


            //to change the display of the button
            string Optdisplay = fristOpt.ToString();
            option1.text = Optdisplay;

            string Optdisplya2 = secondOpt.ToString();
            option2.text = Optdisplya2;
            Correct();

            Shuffle(currentQuiz.Options);

            //print(fristOpt);
            //print(secondOpt);

            //print(currentQuiz.Options.Capacity.ToString());
            
        }



        public void CorrectlistOps()
        {
            if(currentQuiz.correct == currentQuiz.Options[0])
            {
                print("dirt");
            }
            if(currentQuiz.correct == currentQuiz.Options[1])
            {
                print("shoe");
            }
            if (currentQuiz.correct == currentQuiz.Options[2])
            {
                print("mudd");
            }

            //var check = Enum.GetValues(typeof(Testie.FallacyType));
            //currentQuiz.correct = check;

            //int 
            //switch (currentQuiz.correct)
            //{
            //    case check.GetValue():
            //        print("Boobs");
            //        break;
            //}
        }

        IEnumerator NeHex()
        {
            unansweredtest.Remove(currentQuiz);

            yield return new WaitForSeconds(1);
            RunSim();
            //CorrectlistOps();
            //Trap();
            //Correct();
            
        }

        public void Correct()
        {
            
            switch (currentQuiz.Options[0])
            {
                case Testie.FallacyType.adhominem:
                    option1.text = ("Ad Hominem");
                    break;
                case Testie.FallacyType.anecdotalEvidence:
                    option1.text = ("Ancedotal Evidence");
                    break;
                case Testie.FallacyType.appealToAuthority:
                    option1.text = ("Appeal To Authority");
                    break;
                case Testie.FallacyType.blackOrWhite:
                    option1.text = ("Black Or White");
                    break;
                case Testie.FallacyType.correlationCausation:
                    option1.text = ("Coreelation / Causation");
                    break;
                case Testie.FallacyType.hastyGeneralization:
                    option1.text = ("Hasty Generalization");
                    break;
                case Testie.FallacyType.loadedQuestion:
                    option1.text =("Loaded Question");
                    break;
                case Testie.FallacyType.poisoningTheWell:
                    option1.text = ("Poisoning The Well");
                    break;
                case Testie.FallacyType.slipperySlope:
                    option1.text = ("Slippery Slope");
                    break;
                case Testie.FallacyType.appealToEmotions:
                    option1.text = ("Appeal To Emotions");
                    break;
                default:
                    print("No credit today");
                    //tally.RemovePoints(score);
                    break;

            }
                

            switch (currentQuiz.Options[1])
            {
                case Testie.FallacyType.adhominem:
                    option2.text = ("Ad Hominem");
                    break;
                case Testie.FallacyType.anecdotalEvidence:
                    option2.text = ("Ancedotal Evidence");
                    break;
                case Testie.FallacyType.appealToAuthority:
                    option2.text = ("Appeal To Authority");
                    break;
                case Testie.FallacyType.blackOrWhite:
                    option2.text = ("Black Or White");
                    break;
                case Testie.FallacyType.correlationCausation:
                    option2.text = ("Coreelation / Causation");
                    break;
                case Testie.FallacyType.hastyGeneralization:
                    option2.text = ("Hasty Generalization");
                    break;
                case Testie.FallacyType.loadedQuestion:
                    option2.text = ("Loaded Question");
                    break;
                case Testie.FallacyType.poisoningTheWell:
                    option2.text = ("Poisoning The Well");
                    break;
                case Testie.FallacyType.slipperySlope:
                    option2.text = ("Slippery Slope");
                    break;
                case Testie.FallacyType.appealToEmotions:
                    option2.text = ("Appeal To Emotions");
                    break;
                default:
                    print("No credit today");
                    //tally.RemovePoints(score);
                    break;

            }

            //switch (currentQuiz.Options[2])
            //{
            //    case Testie.FallacyType.adhominem:
            //        option1.text = ("Ad Hominem");
            //        break;
            //    case Testie.FallacyType.anecdotalEvidence:
            //        option1.text = ("Ancedotal Evidence");
            //        break;
            //    case Testie.FallacyType.appealToAuthority:
            //        option1.text = ("Appeal To Authority");
            //        break;
            //    case Testie.FallacyType.blackOrWhite:
            //        option1.text = ("Black Or White");
            //        break;
            //    case Testie.FallacyType.correlationCausation:
            //        option1.text = ("Coreelation / Causation");
            //        break;
            //    case Testie.FallacyType.hastyGeneralization:
            //        option1.text = ("Hasty Generalization");
            //        break;
            //    case Testie.FallacyType.loadedQuestion:
            //        option1.text = ("Loaded Question");
            //        break;
            //    case Testie.FallacyType.poisoningTheWell:
            //        option1.text = ("Poisoning The Well");
            //        break;
            //    case Testie.FallacyType.slipperySlope:
            //        option1.text = ("Slippery Slope");
            //        break;
            //    case Testie.FallacyType.appealToEmotions:
            //        option1.text = ("Appeal To Emotions");
            //        break;
            //    default:
            //        print("No credit today");
            //        //tally.RemovePoints(score);
            //        break;

            //}
        }

        public void Wrong()
        {
            tally.RemovePoints(score);
            StartCoroutine(NeHex());
            
        }

        public void control()
        {
            if (Input.GetKeyDown(KeyCode.N))
            {
                StartCoroutine(NeHex());
                //print("Next Question");
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