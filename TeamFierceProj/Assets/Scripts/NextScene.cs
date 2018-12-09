using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextScene : MonoBehaviour {

    //public int nextScene;
    // Use this for initialization

	// Update is called once per frame
	public void moveToNextScene (int next) {
        ScreenFader.Instance.fadeIn = false;
        LevelChanger.Instance.FadeToLevel(next);
    }
}
