using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearonClick : MonoBehaviour {
    // The inspector changable variables
    public GameObject ObjectApeear;
    public float DestroyAfter;

    // Use this for initialization


    private bool appearNow=false;
    bool timer = false;


    public void Start()
    {
        ObjectApeear.SetActive(false);
        
    }

    public void activeNow()
    {
        appearNow = true;
        timer = true;
    }

    public void deactiveNow()
    {
        appearNow = false;
        timer = false;
    }

     void Update()
    {
      
        if (appearNow == true)
        {
           ObjectApeear.SetActive(true);
        }
        if (DestroyAfter > 0 & timer == true)
            DestroyAfter = DestroyAfter - Time.deltaTime;

        if (DestroyAfter < 0 & timer == true)
            ObjectApeear.SetActive(false);
      
    }
	}

