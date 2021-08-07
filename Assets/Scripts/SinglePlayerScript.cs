using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SinglePlayerScript : MonoBehaviour
{
    public Button SingleB,MultiB,ExitB; 
    void Start()
    {
        SingleB.onClick.AddListener(() => ButtonClicked(1));
        MultiB.onClick.AddListener(() => ButtonClicked(2));
        ExitB.onClick.AddListener(() => ButtonClicked(3));
    }
    void ButtonClicked(int buttonNo)
    {
        if(buttonNo == 1)
        {
            SceneManager.LoadScene("Single-Player");
        }
        if(buttonNo == 2)
        {
            SceneManager.LoadScene("Multiplayer");
        }
        if(buttonNo == 3)
        {
            Application.Quit();
        }
    }
}
