using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOnCollide : MonoBehaviour
{
    public string Ptag;

    public bool IsPlayingSolo = true;

    public Transform P1Transform;

    public Transform P2Transform;

    public Rigidbody P1RB;

    public Rigidbody P2RB;

    private void OnCollisionEnter(Collision Collision) 
    {
      if (IsPlayingSolo == true)
      {
        if (Collision.collider.tag == Ptag)
        {
          SceneManager.LoadScene(SceneManager.GetActiveScene().name);  
        }
      }
      else
      {
        if(Collision.collider.tag == Ptag)
        {
          P1Transform.position = new Vector3(0,2,1);

          P1RB.velocity = Vector3.zero;
          P1RB.angularVelocity = Vector3.zero;
        }
        else if (Collision.collider.tag == "Player 2")
        {
          P2Transform.position = new Vector3(0,2,-1);

          P2RB.velocity = Vector3.zero;
          P2RB.angularVelocity = Vector3.zero;
        }
      } 
    }
}
