using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTrigger : MonoBehaviour
{
    private Collider2D collider;

    private void Start()
    {
        collider = this.GetComponent<Collider2D>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Enemy")
        {
            Destroy(gameObject, 0.1f);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "UIEdge")
        {
            Destroy(gameObject, 0.1f);
        }
    }
}