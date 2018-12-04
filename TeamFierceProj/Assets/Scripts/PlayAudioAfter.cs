using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioAfter : MonoBehaviour {

    AudioSource myAudio;
    public float timer;

	// Use this for initialization
	void Start () {
        myAudio = GetComponent<AudioSource>();
        myAudio.PlayDelayed(timer);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
