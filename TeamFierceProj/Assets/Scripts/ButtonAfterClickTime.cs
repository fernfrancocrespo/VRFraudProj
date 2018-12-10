using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ButtonAfterClickTime : MonoBehaviour
{
    //public string levelToLoad;
    public float timer = 10f;
    //public int currentScene;
    public GameObject Object;
    private bool activate=false;

    // Use this for initialization
    void Start()
    {

        if (activate==false) Object.SetActive(false);

    }

    public void startTimer()
    {
        activate = true;
    }

    // Update is called once per frame
    void Update()
    {
         if (activate==true) timer -= Time.deltaTime;
        if (timer <= 0)
        {
            //Application.LoadLevel(levelToLoad);
            // FadeToLevel(0);

            Object.SetActive(true);

            //switch (sceneNum)
            //{
            //    case 0:

            //        break;
            //    case 1:
            //        LevelChanger.Instance.FadeToLevel(0);
            //        break;
            //    case 2:
            //        LevelChanger.Instance.FadeToLevel(1);
            //        break;
            //    default:

            //        break;
            //}



        }
        
    }
    
}