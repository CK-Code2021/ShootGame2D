using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartFlag : MonoBehaviour
{
    private Text textWord;

    private void Start()
    {
        textWord = GetComponent<Text>();
    }

    void Update()
    {
        if (LoadScenes.gameRun == true)
        {
            if (Time.timeSinceLevelLoad < 1)
            {
                textWord.text = "游戏开始";
                textWord.color = Color.green;
            }
            else
            {
                textWord.enabled = false;
            }      
        }
    }
}
