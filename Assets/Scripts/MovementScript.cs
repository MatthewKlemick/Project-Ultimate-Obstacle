using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MovementScript : MonoBehaviour
{
    public int score;

    public bool IsPlaying = true;

    public string Endtag;

    public Text ScoreText;

    public Text EndText;

    public Vector3 MVector;

    public Vector3 MVector2;

    public KeyCode Key1;

    public KeyCode Key2;

    public KeyCode Key3;

    public KeyCode Key4;

    public KeyCode MenuKey;

    public KeyCode ResetKey = KeyCode.R;

    public string WinText = "YOU WIN Your final score is: ";

    public string ScoreTextString = "Score: ";

    public Transform ControlObject;

    void FixedUpdate()
    {

        if (Input.GetKey(Key1))
        {
            GetComponent<Rigidbody>().velocity += MVector;
        }

        if (Input.GetKey(Key2))
        {
            GetComponent<Rigidbody>().velocity -= MVector;
        }

        if (Input.GetKey(Key3))
        {
            GetComponent<Rigidbody>().velocity += MVector2;
        }

        if (Input.GetKey(Key4))
        {
            GetComponent<Rigidbody>().velocity -= MVector2;
        }

        if (Input.GetKey(MenuKey))
        {
            SceneManager.LoadScene("Menu");
        }
        if (Input.GetKey(ResetKey))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        updateScore ();
    }
    void updateScore()
    {
        if (IsPlaying == true)
        {
            score = score + 1;
        }
        ScoreText.text = ScoreTextString + score.ToString ();
    }
    
    private void OnCollisionEnter(Collision Collision) 
    {
        if (Collision.collider.tag == Endtag)
        {
            IsPlaying = false;
            
            if(ControlObject.position != new Vector3(0,-2,0))
            {  
            EndText.text = WinText + score.ToString ();
            ControlObject.position = new Vector3(0,-2,0);  
            }
        } 
    }
}
