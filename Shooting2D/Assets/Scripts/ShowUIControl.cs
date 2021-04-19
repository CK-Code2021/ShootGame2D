using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowUIControl : MonoBehaviour
{
    public GameObject gameObject;
    public OverUIControl overUIControl;   

    public void Update()
    {
        if (TowerControl.towerLive == false)
        {
            if (DelayTime.DelayGenerate1(1))
            {
                DeactivateChildren(gameObject, true);               
                overUIControl.GameFail();
            }
        }
        else if (TimeControl.countDownSecond == 0 && TowerControl.towerLive == true)
        {
            if (DelayTime.DelayGenerate1(1))
            {
                DeactivateChildren(gameObject, true);             
                overUIControl.GameWin();
            }
        }
        else
        {
            DeactivateChildren(gameObject, false);           
        }
    }

    //隐藏物体以及物体的所有子物体
    public static void DeactivateChildren(GameObject g, bool a)
    {
        g.SetActive(a);

        foreach (Transform child in g.transform)
        {
            DeactivateChildren(child.gameObject, a);
        }
    }
}
