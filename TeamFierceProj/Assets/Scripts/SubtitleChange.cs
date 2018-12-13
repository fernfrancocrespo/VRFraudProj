using System.Collections; using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SubtitleChange : MonoBehaviour {

    //public TextMeshProUGUI m_MyText;
    public TextMeshPro m_MyText;     public string initialSubtitle;     //public Animator scene4Animator;
    private float timer = 42f;     private float timer1 = 0f;     public int sceneNum;
    void Start()     {
        //Text sets your text to say this message
        m_MyText.text = initialSubtitle;     }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;         timer1 += Time.deltaTime;

        //timerSecond.text = timer.ToString("f2");
        if (timer <= 0 && timer >= -1f && sceneNum == 1)
        {
            m_MyText.text = "Lowel Smith...";
        }         switch(sceneNum)
        {             case 1:                 if (timer <= 0 && timer >= -1f)
                {
                    m_MyText.text = "Lowel Smith...";
                }                 break; 
            case 3:                  if (timer1 >= 2.0 && timer1 <= 3.0)                 {                     m_MyText.text = "Jeremy...";                 }                 else if (timer1 >= 3.0 && timer1 <= 7.0)                 {                     m_MyText.text = "Ian...";                 }                 else if (timer1 >= 7.0 && timer1 <= 10.0)                 {                     m_MyText.text = "Jeremy...";                 }                 else if (timer1 >= 10.0 && timer1 <= 23.0)                 {                     m_MyText.text = "Ian...";                 }                 else if(timer1 >= 23.0)
                {
                    m_MyText.text = "Jeremy...";
                }                  break;

            case 4:                  if (timer1 >= 4.0 && timer1 <= 19.0)                 {                     m_MyText.text = "Ian...";                 }                 else if (timer1 >= 19.0 && timer1 <= 28.0)                 {                     m_MyText.text = "Julia...";                   }                 else if (timer1 >= 28.0 && timer1 <= 33.0)                 {                     m_MyText.text = "Ian...";                  }                 else if (timer1 >= 33.3)                 {                     m_MyText.text = "Julia...";                 }                 break;

            case 5:                  if (timer1 >= 10.5)                 {                     m_MyText.text = "Julia...";                 }                  break;

            case 8:                  if (timer1 >= 8.0 && timer1 <= 9.0)                 {                     m_MyText.text = "Lindon...";                 }                 else if (timer1 >= 9.0 && timer1 <= 17.0)                 {                     m_MyText.text = "Julia...";                 }                 else if (timer1 >= 17.0 && timer1 <= 21.0)                 {                     m_MyText.text = "Kenrick...";                 }                 else if (timer1 >= 21.0 && timer1 <= 25.5)                 {                     m_MyText.text = "Dani...";                 }                 else if (timer1 >= 25.5)                 {                     m_MyText.text = "Julia...";                 }                 break; 
            case 9:                  if (timer1 >= 4.0 && timer1 <= 6.0)                 {                     m_MyText.text = "Kenrick...";                 }                 else if (timer1 >= 6.0 && timer1 <= 8.0)                 {                     m_MyText.text = "Dani...";                 }                 else if (timer1 >= 8.0 && timer1 <= 13.0)                 {                     m_MyText.text = "Kenrick...";                 }                 else if (timer1 >= 13.0 && timer1 <= 25.5)                 {                     m_MyText.text = "Dani...";                 }                 else if (timer1 >= 25.5)                 {                     m_MyText.text = "Julia...";                 }                 break; 
            case 10:                  if (timer1 >= 3.0 && timer1 <= 7.0)                 {                     m_MyText.text = "Lindon...";                 }                 else if (timer1 >= 7.0 && timer1 <= 15.5)                 {                     m_MyText.text = "Caleb...";                 }                 else if (timer1 >= 15.5 && timer1 <= 18.0)                 {                     m_MyText.text = "Julia...";                 }                 else if (timer1 >= 18.0 && timer1 <= 26.0)                 {                     m_MyText.text = "Caleb...";                 }                 else if (timer1 >= 26.0 && timer1 <= 32.0)                 {                     m_MyText.text = "Lindon...";                 }                 else if (timer1 >= 32.0 && timer1 <= 36.0)                 {                     m_MyText.text = "Caleb...";                 }                 else if (timer1 >= 36.0 && timer1 <= 48.0)                 {                     m_MyText.text = "Julia...";                 }                 else if (timer1 >= 48.0 && timer1 <= 49.0)                 {                     m_MyText.text = "Dani...";                 }                 else if (timer1 >= 49.0 && timer1 <= 54.0)                 {                     m_MyText.text = "Kenrick...";                 }                  else if (timer1 >= 54.0)                 {                     m_MyText.text = "Caleb...";                 }                 break;

            case 11:                  if (timer1 >= 4.0 && timer1 <= 16.0)                 {                     m_MyText.text = "Gerard...";                 }                  else if (timer1 >= 16.0)                 {                     m_MyText.text = "Heather...";                 }                 break;
            case 12:                  if (timer1 >= 4.7)                 {                     m_MyText.text = "Gerard...";                 }                 break;

            case 14:                  if (timer1 >= 5.5 && timer1 <= 12.0)                 {                     m_MyText.text = "Dani...";                 }                 else if (timer1 >= 12.0)                 {                     m_MyText.text = "Jennie...";                 }                 break;

            case 16:                 if (timer1 >= 5.0)                 {                     m_MyText.text = "Rosemary...";                 }                 break;

            case 19:                 if (timer1 >= 2.5)                 {                     m_MyText.text = "Gerard...";                 }                 break;

            case 21:                 if (timer1 >= 7.0)                 {                     m_MyText.text = "Owen...";                 }                 break;

            case 23:                 if (timer1 >= 8.5)                 {                     m_MyText.text = "Dani...";                 }                 break;

            case 24:                 if (timer1 >= 5.0)                 {                     m_MyText.text = "Lowel...";                 }                 break; 
        }  
    }
    public void changeSubtitle(string s)
    {
        m_MyText.text = s;
    }
}
