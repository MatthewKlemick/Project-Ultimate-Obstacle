using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotScript : MonoBehaviour
{

    public float Rotspeed;

    void FixedUpdate()
    {
        transform.Rotate (0, Rotspeed * Time.deltaTime,0);
    }
}
