using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;
public class TimerScript : MonoBehaviour
{
    public float TimeLeft;
    public bool TimerOn = false;

    public TMP_Text TimerTXT;

    void Start()
    {
        
    }

    void Update()
    {
        if(TimerOn){
            if(TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                updateTimer(TimeLeft);
            }
            else{
                Debug.Log("Time's up");
                GlobalBehavior.GlobalBehaviorInstance.isTimeUp = true;
                SceneManager.LoadScene(3);

                TimeLeft = 0;
                TimerOn = false;
            }
        }
        
    }

    void updateTimer(float currenTime)
{
    currenTime += 1;
    float minutes = Mathf.FloorToInt(currenTime / 60);
    float seconds = Mathf.FloorToInt(currenTime % 60);
    
    TimerTXT.text = string.Format("{0:00}:{1:00}", minutes, seconds);
}

}
