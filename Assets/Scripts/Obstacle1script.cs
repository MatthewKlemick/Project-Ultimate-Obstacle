using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle1script : MonoBehaviour
{

    public float distance;

    public float speed;

    public Vector3 Startingpos;
    
    public Transform Obstacle;

    void FixedUpdate()
    {
        Vector3 V = Startingpos;

        V.z += distance * Mathf.Sin(Time.time * speed);

        Obstacle.position = V;

    }
}
