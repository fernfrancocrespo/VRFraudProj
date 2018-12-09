using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelChanger : singleton<LevelChanger>
{
    public Animator animator;
    private int levelToLoad;

    protected LevelChanger() { }

    // Update is called once per frame
 //   void Update () {

	//	 if (Input.GetMouseButtonDown(0))
 //        {
 //            FadeToLevel(1);
 //        }
		
	//}

	public void FadeToLevel(int levelIndex)
    {
        levelToLoad = levelIndex;
        animator.SetTrigger("FadeOut");

    }
    public void OnFadeComplete ()
    {
        animator.ResetTrigger("FadeOut");
        SceneManager.LoadScene(levelToLoad);
    }
}