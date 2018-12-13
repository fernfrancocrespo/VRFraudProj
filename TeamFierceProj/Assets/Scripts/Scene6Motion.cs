using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene6Motion : MonoBehaviour {

    Animator scene6Animator;
    private float timer1 = 0f;

    // Use this for initialization
    void Start()
    {
        scene6Animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        timer1 += Time.deltaTime;
        if (timer1 >= 25.5)
        {
            scene6Animator.SetTrigger("Gesture");
        }


    }
}
