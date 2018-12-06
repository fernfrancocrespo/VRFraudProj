using UnityEngine;
using UnityEngine.UI;

public class AfterBTimer : MonoBehaviour
{
    //public string levelToLoad;
    public float timer = 10f;
    private Text timerSecond;
    //public int currentScene;
    public int nextScene;
    private bool activate=false;

    // Use this for initialization
    void Start()
    {

        timerSecond = GetComponent<Text>();

    }

    public void startTimer()
    {
        activate = true;
    }

    // Update is called once per frame
    void Update()
    {
         if (activate==true) timer -= Time.deltaTime;
        timerSecond.text = timer.ToString("f2");
        if (timer <= 0)
        {
            //Application.LoadLevel(levelToLoad);
            // FadeToLevel(0);

            LevelChanger.Instance.FadeToLevel(nextScene);

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