using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OverUIControl : MonoBehaviour
{
    private Text textWord;

    private void Start()
    {        
        textWord = GetComponent<Text>();
        textWord.enabled = false;
    }

    public void GameFail()
    {
        textWord.enabled = true;
        textWord.text = "游戏结束";
        textWord.color = Color.red;
    }

    public void GameWin()
    {
        textWord.enabled = true;
        textWord.text = "成功通关";
        textWord.color = Color.green;
    }
}
