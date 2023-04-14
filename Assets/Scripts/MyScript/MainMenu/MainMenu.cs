using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("you hit play button");
    }


    public void HighScore(){
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        Debug.Log("you hit highscore button");
    }
    public void Exit()
    {
     Application.Quit();   
        Debug.Log("Exiting....");

    }


    
}
