using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TowerControl : MonoBehaviour
{
    public static bool towerLive = true;
    public float maxBlood = 5; 
    private float nowBlood = 0;
    private float BloodLength = 0;                           //血条长度

    private void Start()
    {
        nowBlood = maxBlood;
        BloodLength = transform.GetChild(0).localScale.x;    //记录血条长度
        TowerHP();                                           //初始时加载血条
    }

    private void Update()
    {
        if (LoadScenes.gameRun == true)
        {       
            if (DelayTime.DelayGenerate1(1))
            {                
                TowerHP();
           
                if (nowBlood == 0)
                {
                    this.GetComponent<Animator>().SetBool("DestroyBool", true);
                    towerLive = false;
                }
            }           
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Enemy")
        {
            TowerBlood();
        }
    }

    private void TowerBlood()
    {
        if (nowBlood > 0)
            nowBlood -= 1;  
    }

    //加载血条长度
    private void TowerHP()
    {
        transform.GetChild(0).localScale =
            new Vector3(nowBlood / maxBlood * BloodLength, transform.GetChild(0).localScale.y, 0);
    }
}
