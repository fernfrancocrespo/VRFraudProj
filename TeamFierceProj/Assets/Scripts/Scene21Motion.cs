using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene21Motion : MonoBehaviour {

    Animator sceneAnimator;
    private float timer1 = 0f;

    // Use this for initialization
    void Start()
    {
        sceneAnimator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        timer1 += Time.deltaTime;
        if (timer1 >= 8.5)
        {
            sceneAnimator.SetTrigger("Gesture");
        }


    }
}
