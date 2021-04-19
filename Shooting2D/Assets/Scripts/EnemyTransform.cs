using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTransform : MonoBehaviour
{
    public float speed = 3;
    public static float changeSpeed = 1;
    private Collider2D collider;

    private void Start()
    {
        collider = this.GetComponent<Collider2D>();
    }

    void Update()
    {
        transform.Translate(-transform.right * Time.deltaTime *changeSpeed * speed, 0);
    }

    //碰撞
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Tower" || other.transform.tag == "Buttle" || other.transform.tag == "UIEdge")       
            collider.GetComponent<Animator>().SetBool("DestroyBool", true);                    
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "UIEdge")
        {
            Destroy(gameObject, 0.1f);
        }
    }
}
