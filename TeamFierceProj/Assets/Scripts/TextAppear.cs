using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextAppear : MonoBehaviour
{

    public float ActivateAfter;
    public GameObject text;

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
        }
    }
}

