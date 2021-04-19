using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayTime
{
    public static float nextTime = 0;

    //函数作用：延迟数秒
    public static bool DelayGenerate(int delayTime)
    {
        if (nextTime == 0)
            nextTime = Time.time;

        if (Time.time > nextTime + delayTime)
        {           
            nextTime = 0;
            return true;
        }
               
        return false;
    }

    public static float nextTime1 = 0;

    public static bool DelayGenerate1(int delayTime)
    {
        if (nextTime1 == 0)
            nextTime1 = Time.time;

        if (Time.time > nextTime1 + delayTime)
        {
            nextTime1 = 0;
            return true;
        }

        return false;
    }
}
