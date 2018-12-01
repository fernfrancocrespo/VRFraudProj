using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearonClick : MonoBehaviour {
    // The inspector changable variables
    public GameObject text;
    public float DestroyAfter;

    // Use this for initialization


    private bool appearNow=false;
    bool timer = false;


    public void Start()
    {
        text.SetActive(false);
        
    }

    public void activeNow()
    {
        appearNow = true;
        timer = true;
    }

     void Update()
    {
      
        if (appearNow == true)
        {
            text.SetActive(true);
        }
        if (DestroyAfter > 0 & timer == true)
            DestroyAfter = DestroyAfter - Time.deltaTime;

        if (DestroyAfter < 0 & timer == true)
            text.SetActive(false);
      
    }
	}

