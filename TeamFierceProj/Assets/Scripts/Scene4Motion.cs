using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene4Motion : MonoBehaviour {

    Animator scene4Animator;
    private float timer1 = 0f;

    // Use this for initialization
    void Start () {
        scene4Animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        timer1 += Time.deltaTime;

        if (timer1 >= 19.0 && timer1 <= 28.0)
        {
            scene4Animator.SetTrigger("Gesture");
        }
        else if (timer1 >= 28.0 && timer1 <= 33.0)
        {
            scene4Animator.ResetTrigger("Gesture");
            scene4Animator.SetTrigger("Return");
        }
        else if (timer1 >= 33.3)
        {
            scene4Animator.ResetTrigger("Return");
            scene4Animator.SetTrigger("Gesture");
        }


    }
}
