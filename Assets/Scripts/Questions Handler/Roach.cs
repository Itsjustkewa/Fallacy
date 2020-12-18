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
        public static Roach instance;

        public Testie[] testie;

        [Header("Questions")]
        public Bug[] quiz;
        private List<Bug> unansweredtest;
        private List<Bug> Binned = new List<Bug>();
        public Bug currentQuiz= new Bug();
        private Testie lure;
        private int score;

        [SerializeField]private List<GameObject> optionsList = new List<GameObject>();
        

        [Header("Settings")]
        
        [SerializeField]private PointSystem tally;
        [SerializeField]private Text QuestionText;

        [Header("Option Buttons Text")]
        [SerializeField]private Text option1;
        [SerializeField]private Text option2;
        [SerializeField]private Text option3;
        [SerializeField]private Text option4;
        

        [SerializeField]private bool isRight;

        [Header("Answer")]
        public int optionCount;


        private void Awake()
        {
            //if (instance == null)
            //{
            //    instance = this;
            //}
            //else
            //{
            //    Destroy(this);
            //    return;
            //}
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
            
            
        }       

        private void RunSim()
        {
            if(unansweredtest.Count <= 0)
            {
                foreach(Bug n in Binned)
                {
                    unansweredtest.Add(n);
                }
                Binned.Clear();
            }

            int randomBugIndex = UnityEngine.Random.Range(0, unansweredtest.Count);
            currentQuiz = unansweredtest[randomBugIndex];
            QuestionText.text = currentQuiz.Questions;



            

            List<Testie.FallacyType> tempList = new List<Testie.FallacyType>(new Testie.FallacyType[9]);
            tempList = currentQuiz.Options;
            

            int currentindex;
            currentindex = currentQuiz.Options.Capacity;

            //The strings to the options.
            var fristOpt = currentQuiz.Options[0];
            var secondOpt = currentQuiz.Options[1];
            var thirdOpt = currentQuiz.Options[2];
            var fourthOpt = currentQuiz.Options[3];


            

            //to change the display of the button
            string Optdisplay = fristOpt.ToString();
            option1.text = Optdisplay;

            string Optdisplya2 = secondOpt.ToString();
            option2.text = Optdisplya2;

            string Optdisplay3 = thirdOpt.ToString();
            option3.text = Optdisplay3;

            string Optdisplay4 = fourthOpt.ToString();
            option4.text = Optdisplay4;

            

            OptionsTextControl();

            

            Checking();

            
            

            OptionMatch(currentQuiz);
            
        }
        public bool Adding(GameObject gameObject)
        {
            Bug opts = gameObject.GetComponent<Bug>();
            if(opts == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //public GameObject GetGameObject(int index)
        //{
        //    var issue = new Dictionary<Testie.FallacyType, GameObject>();
        //    //issue [0] =  
        //}
        



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

            
        }

        IEnumerator NeHex()
        {
            unansweredtest.Remove(currentQuiz);

            Binned.Add(currentQuiz);
            yield return new WaitForSeconds(1);
            RunSim();
            
        }

        public void Checking()// tried to populate the list and print them
        {
            //Get the possible value from the enum to populate the list
            //var fill = Enum.GetValues(typeof(Testie.FallacyType)).Cast<Testie.FallacyType>().ToList();

            List<Testie.FallacyType> Optlist = new List<Testie.FallacyType>();

            currentQuiz.Options.AddRange(Optlist);

            

            

            foreach(var v in currentQuiz.Options)
            { 
                //print(v);
            }
            
        }

        public void OptionMatch(Bug Correct)// getting the index and matching them with the correct one
        {
            if (currentQuiz.Options.Exists(x => x == Correct.correct))
            {
                int index = currentQuiz.Options.FindIndex(x => x == Correct.correct);
                //print(index);
                return;
                //it SHOWS THE CORRECT ANSWER
            }
            
        }

        

        public void OptionsTextControl() //its controles the text of the game object 
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

            switch (currentQuiz.Options[2])
            {
                case Testie.FallacyType.adhominem:
                    option3.text = ("Ad Hominem");
                    break;
                case Testie.FallacyType.anecdotalEvidence:
                    option3.text = ("Ancedotal Evidence");
                    break;
                case Testie.FallacyType.appealToAuthority:
                    option3.text = ("Appeal To Authority");
                    break;
                case Testie.FallacyType.blackOrWhite:
                    option3.text = ("Black Or White");
                    break;
                case Testie.FallacyType.correlationCausation:
                    option3.text = ("Coreelation / Causation");
                    break;
                case Testie.FallacyType.hastyGeneralization:
                    option3.text = ("Hasty Generalization");
                    break;
                case Testie.FallacyType.loadedQuestion:
                    option3.text = ("Loaded Question");
                    break;
                case Testie.FallacyType.poisoningTheWell:
                    option3.text = ("Poisoning The Well");
                    break;
                case Testie.FallacyType.slipperySlope:
                    option3.text = ("Slippery Slope");
                    break;
                case Testie.FallacyType.appealToEmotions:
                    option3.text = ("Appeal To Emotions");
                    break;
                default:
                    print("No credit today");
                    //tally.RemovePoints(score);
                    break;

            }

            switch (currentQuiz.Options[3])
            {
                case Testie.FallacyType.adhominem:
                    option4.text = ("Ad Hominem");
                    break;
                case Testie.FallacyType.anecdotalEvidence:
                    option4.text = ("Ancedotal Evidence");
                    break;
                case Testie.FallacyType.appealToAuthority:
                    option4.text = ("Appeal To Authority");
                    break;
                case Testie.FallacyType.blackOrWhite:
                    option4.text = ("Black Or White");
                    break;
                case Testie.FallacyType.correlationCausation:
                    option4.text = ("Correelation / Causation");
                    break;
                case Testie.FallacyType.hastyGeneralization:
                    option4.text = ("Hasty Generalization");
                    break;
                case Testie.FallacyType.loadedQuestion:
                    option4.text = ("Loaded Question");
                    break;
                case Testie.FallacyType.poisoningTheWell:
                    option4.text = ("Poisoning The Well");
                    break;
                case Testie.FallacyType.slipperySlope:
                    option4.text = ("Slippery Slope");
                    break;
                case Testie.FallacyType.appealToEmotions:
                    option4.text = ("Appeal To Emotions");
                    break;
                default:
                    print("No credit today");
                    //tally.RemovePoints(score);
                    break;

            }

        }

        public void Wrong()
        {
            tally.RemovePoints(score);
            StartCoroutine(NeHex());
            
        }

        public void control()
        {
            StartCoroutine(NeHex());
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