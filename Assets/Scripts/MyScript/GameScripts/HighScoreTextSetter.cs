using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using System.Text;

using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using Unity.XR.CoreUtils;

public class HighScoreTextSetter : MonoBehaviour
{
    // public Text HighScoreText;

    public int Score;
    public Text HighScoreText;

    void start()
    {
        init();
    }

    void init()
    {
        // Score = PlayerPrefs.GetInt("score");
        Score = 5;
        HighScoreText.text = "HighScore is : " + Score;
    }

    void update()
    {
        HighScoreText.text = "HighScore is : " + Score;
    }
}
