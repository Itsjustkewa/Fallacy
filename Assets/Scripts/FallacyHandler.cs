using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Foolacy.Main
{ 

    public class FallacyHandler : MonoBehaviour
    {
        public static FallacyHandler instance;

        [Header("Fallacies")]
        public Fallacy[] fallacyQuestions; //Creating an arrry
        private List<Fallacy> unansweredFacllay;
        private List<Fallacy> Bin = new List<Fallacy>();

        private Fallacy currenctFact;

        [Header("Settings")]
        [SerializeField]
        private PointSystem marks;

        [SerializeField]
        //private SceneManagerScript sceneManager;

        private int Points;
        

        [SerializeField]
        private Text fallacyText;

        [SerializeField]
        private float breathTime = 1f;

        private void Start()
        {
            if(unansweredFacllay == null || unansweredFacllay.Count == 0)
            { 
                unansweredFacllay = fallacyQuestions.ToList<Fallacy>();
            }

            SetFallacyQuestion();
        }

        void SetFallacyQuestion()
        {   
            if(unansweredFacllay.Count <= 0)
            {
                foreach(Fallacy f in Bin)
                {
                    unansweredFacllay.Add(f);
                }
                Bin.Clear();
            }
            int randomFallacyIndex = Random.Range(0, unansweredFacllay.Count);
            currenctFact = unansweredFacllay[randomFallacyIndex];

            fallacyText.text = currenctFact.FallacyType;

        }

        IEnumerator NextQuestion()
        {
            unansweredFacllay.Remove(currenctFact);
            Bin.Add(currenctFact);

            yield return new WaitForSeconds(breathTime);

            
            SetFallacyQuestion();
            
        }

        public void IsTrue()
        {
            if (currenctFact.isCorrect)
            {
                Debug.Log("True");
                marks.AddPoints(Points);
            }
            else
            {
                marks.RemovePoints(Points);
                Debug.Log("false");
            }

            StartCoroutine(NextQuestion());
        }

        public void IsntTrue()
        {
            if (!currenctFact.isCorrect)
            {
                marks.AddPoints(Points);
                Debug.Log("True ");
            }
            else
            {
                marks.RemovePoints(Points);
                Debug.Log("false");
            }

            StartCoroutine(NextQuestion());
        }

    }
}