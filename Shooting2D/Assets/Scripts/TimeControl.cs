using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeControl : MonoBehaviour
{
    public int countDownMinute = 2;                         //倒计时单位分钟
    public static int countDownSecond = 0;                  //倒计时总秒数
    private int minute = 0;
    private int second = 0;
    private Text timeText;

    private void Start()
    {
        timeText = GetComponent<Text>();
        countDownSecond = countDownMinute * 60;      
    }

    void Update()
    {
        if (LoadScenes.gameRun == true && TowerControl.towerLive == true)
        {
            if (countDownSecond > 0)
            {
                if (DelayTime.DelayGenerate(1))
                {                  
                    countDownSecond -= 1;
                    minute = countDownSecond / 60;
                    second = countDownSecond % 60;

                    if (countDownSecond % 60 > 9)
                        timeText.text = minute + ":" + second;
                    else
                        timeText.text = minute + ":0" + second;                  
                }
            }
        }
    }
}
