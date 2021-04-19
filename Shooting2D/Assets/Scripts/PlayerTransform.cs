using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTransform : MonoBehaviour
{
    public float speed = 2f;
    public static float changeSpeed = 1;

    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * changeSpeed * speed,
            Input.GetAxis("Vertical") * Time.deltaTime * changeSpeed* speed, 0);        
    }
}
