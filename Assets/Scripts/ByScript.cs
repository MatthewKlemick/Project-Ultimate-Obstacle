using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ByScript : MonoBehaviour
{
    public Vector3 Goto;

    public Vector3 OrignalPos;
    
    public Transform Obstacle;

    void start()
    {
        OrignalPos = Obstacle.position;
    }

    private void OnCollisionEnter(Collision Collision) 
    {
        if (Collision.collider.tag == "Player")
        {
            StartCoroutine(by());
        }
        if (Collision.collider.tag == "Player 2")
        {
            StartCoroutine(by());
        }

    }
    IEnumerator by() 
    {
        yield return new WaitForSeconds(1);

        Obstacle.position = Goto;

        yield return new WaitForSeconds(2);

        Obstacle.position = OrignalPos;

    }
}
