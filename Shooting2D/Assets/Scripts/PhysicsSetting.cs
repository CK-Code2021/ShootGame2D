using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsSetting : MonoBehaviour
{
    void Start()
    {
        //8:Back   9:Player   10:Enemy   11:Bullet
        Physics2D.IgnoreLayerCollision(8, 10);
        Physics2D.IgnoreLayerCollision(8, 11);
        Physics2D.IgnoreLayerCollision(9, 10);
        Physics2D.IgnoreLayerCollision(10, 10);
    }
}
