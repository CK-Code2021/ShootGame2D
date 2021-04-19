using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
    public static bool gameRun = false;

    public void OnStartLick()
    {
        SceneManager.LoadScene("GameScene");      
        gameRun = true;
        TowerControl.towerLive = true;
        EnemyTransform.changeSpeed = 1;
        PlayerTransform.changeSpeed = 1;
    }

    public void OnOverLick()
    {
        Application.Quit();
    }

    public void LoadGameOverUI()
    {       
        gameRun = false;       
    } 

    public void OnExistLick()
    {
        SceneManager.LoadScene("StartScene");
        gameRun = false;       
    }
}
