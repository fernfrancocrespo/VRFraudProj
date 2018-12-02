using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextAppear : MonoBehaviour
{

    public float ActivateAfter;
    public GameObject text;
    public float destroyAfter;
    private bool active = true;


    // Use this for initialization
    private void Start()
    {
    }



    // Update is called once per frame
    void Update()
    {
        if (ActivateAfter > 0)
        {

            text.SetActive(false);
            ActivateAfter -= Time.deltaTime;
        }

        
        else if (ActivateAfter <= 0)
        {

            text.SetActive(true);
            active = true;
        }

        if (active == true)
        {
            if (destroyAfter > 0)
            { destroyAfter -= Time.deltaTime; }
            else if (destroyAfter<=0)
            {
                text.SetActive(false);
            }
        }
    }
}

