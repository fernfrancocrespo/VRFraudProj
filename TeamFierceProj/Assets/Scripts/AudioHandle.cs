using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioHandle : MonoBehaviour {

    public AudioSource audioSource;
    public AudioClip clip;
    public float startAfter = 2f;

    // Use this for initialization
    void Start () {
        audioSource.clip = clip;
        audioSource.Pause();

    }

    // Update is called once per frame
    void Update()
    {
        startAfter -= Time.deltaTime;
        if (startAfter >= 0.3f && startAfter <= 0.5f)
        {
            audioSource.Play(0);
        }
    }
}