using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public GameObject bullet;
    private GameObject clone;

    public void Shooting()
    {      
        clone = (GameObject)Instantiate(bullet, transform.GetChild(0).position, transform.GetChild(0).rotation);
        clone.GetComponent<Rigidbody2D>().velocity = transform.right * 20;
    }
}
