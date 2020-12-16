using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using Foolacy.Main;

[System.Serializable]
public class Bug
{
    [TextArea(3, 5)] public string Questions;
    public List<Testie.FallacyType> Options;
    public Testie.FallacyType correct;
    //public int optSize;


    //To generate options and randomize the options. 
    public void OptGen(int n)//n is the size of the option list.
    {
        var opts = Enum.GetValues(typeof(Testie.FallacyType)).Cast<Testie.FallacyType>().ToList();
        opts.Remove(correct);


        //create a new list
        //take n-1 element randomly into the new list
        //add correct back into new list
        //shuffle new list 
        //options to new list. 

        List<Testie.FallacyType> guess = new List<Testie.FallacyType>();
        guess.RemoveAt(n-1);
        guess.Add(correct);
        Shuffle(guess);
        guess = Options;

        return ;
        //Testie.FallacyType[] temp = new Testie.FallacyType[] { };
        //List<Testie.FallacyType> temp2 = new List<Testie.FallacyType>(temp);
    }



    //trying to get the list
    //public List<Testie.FallacyType> GetList()
    //{
    //    return Options;
    //}

    //created the shuffle funtion thanks to stackoverflow.com/questions/273313/randomize-a-listt-in-c-sharp
    private static System.Random rng = new System.Random();

    public static void Shuffle<X>(IList<X> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            X value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }

    
}
