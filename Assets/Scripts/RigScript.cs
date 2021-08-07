using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigScript : MonoBehaviour
{

    public float Rotspeed;

    public Transform target;

    public KeyCode RKey;

    public KeyCode RNKey;

    void FixedUpdate()
    {
       transform.position = target.position;
        
        if (Input.GetKey(RKey))
        {
            transform.Rotate (0, Rotspeed ,0);
        }
        
        if (Input.GetKey(RNKey))
        {
            transform.Rotate (0, -Rotspeed ,0);
        }  
    }
}
