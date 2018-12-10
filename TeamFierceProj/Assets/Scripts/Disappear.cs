using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear: MonoBehaviour {
   
    public GameObject Object;
    private bool disappear = false;

    // Use this for initialization
    private void Start()
    {   
    }

    public void disNow()
    {
        disappear = true;
    }
   

    // Update is called once per frame
    void Update () {
       
           if (disappear==true)
           Object.SetActive(false);
          
      

     
        
		
	}
}
