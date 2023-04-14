using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class testwscript : MonoBehaviour
{
    public TextMeshProUGUI trst;

    int score;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("testscript start start");

        score = CollisionDetector.MainCounter;

        Debug.Log("testscript start score");

        int HighScore = PlayerPrefs.GetInt("high_score");
        if (HighScore < score)
        {
            PlayerPrefs.SetInt("high_score", score);
        }

        trst.text = "Your Score is : " + score;
        Debug.Log("testscript start score set");
    }

    // Update is called once per frame
    void Update() { }

    public void BackToMainMenu()
    {
        Debug.Log("testscript backto mainmenu");

        CollisionDetector.MainCounter = 0; // reseting counter
        SceneManager.LoadScene("MainMenu");
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);

        Debug.Log("Exiting....");
    }
}
