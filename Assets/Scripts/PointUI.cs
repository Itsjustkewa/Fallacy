using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Foolacy.Main
{ 
    public class PointUI : MonoBehaviour
    {
        public static PointUI instance;

        public Transform bar;


        public void Awake()
        {
            bar = transform.Find("Bar");
            
        }
        // Start is called before the first frame update
        public void Start()
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

        public void SetSize(float funds)
        {
            bar.localScale = new Vector3(funds, 1f);
        }


    }
}