using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Roach : MonoBehaviour, IPointerDownHandler
{

    public GameObject Butt;
    

    // Start is called before the first frame update
    void Awake()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Rubie();
    }

    public void Rubie()
    {
        
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
            if(Butt = this.gameObject)
            {
                Debug.Log("Here We Go");
            }

    }

   
}