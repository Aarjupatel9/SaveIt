using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class HighScoreSceneHandler : MonoBehaviour
{
    public TextMeshProUGUI trst;

    int HighScore;

    // Start is called before the first frame update
    void Start()
    {
        HighScore = PlayerPrefs.GetInt("high_score");

        trst.text = "Your Score is : " + HighScore;
    }

    // Update is called once per frame
    void Update() { }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
        Debug.Log("Exiting....");
    }
}
