using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BrithEnemy : MonoBehaviour
{
    public GameObject[] enemy;           
    private int random01 = 0;                       //随机数1：确定生成怪的种类
    private int random02 = 0;                       //随机数1：确定生成怪的地点
    private float intervalTime = 3;                 //间隔时间
    private float nextTime = 0;

    private void Start()
    {
        nextTime = intervalTime;
    }

    void Update()
    {
        if (LoadScenes.gameRun == true)
        {
            if (TowerControl.towerLive == true)
            {
                if (Time.timeSinceLevelLoad > nextTime && TimeControl.countDownSecond > 1)
                {
                    if (intervalTime >= 1)
                        intervalTime -= 0.05f;

                    nextTime += intervalTime;
                    random01 = Random.Range(0, 2);   //敌人随机值
                    random02 = Random.Range(0, 4);   //生成点随机值
                    Instantiate(enemy[random01], transform.GetChild(random02).position, transform.GetChild(random02).rotation);

                    if (EnemyTransform.changeSpeed < 3)
                        ChangeEnemySpeed();                                      
                }
                else if (TimeControl.countDownSecond == 0)
                {
                    this.GetComponent<Animator>().SetBool("DestroyBool", true);                  
                }
            }          
        }
    }

    private void ChangeEnemySpeed()
    {
        EnemyTransform.changeSpeed += 0.1f;
        PlayerTransform.changeSpeed += 0.07f;     
    }
}
