using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using Foolacy.Main;

[System.Serializable]
public class Bug
{
    public string Questions;
    public List<Testie.FallacyType> Options;
    //public List<string> Options;
    //public int CorrectIndex;
    public Testie.FallacyType correct;
    

    public void OptGen(int n)
    {
        
        var opts = Enum.GetValues(typeof(Testie.FallacyType)).Cast<Testie.FallacyType>().ToList();
        opts.Remove(correct);

        List<Testie.FallacyType> guess = new List<Testie.FallacyType>();
        //guess.Remove(n);
        guess.Add(correct);
        //Options = guess;

        //create a new list
        //take n-1 element randomly into the new list
        //add correct back into new list
        //shuffle new list 
        //options to new list. 
        
         
    }
}
