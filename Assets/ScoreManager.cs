using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;
    public float score = 0;
    public int pointsPerSecond = 1;
    public float highscore = 0;

    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetFloat("highscore", 0);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = Mathf.FloorToInt(score).ToString();
        highscoreText.text = "Highscore:" + Mathf.FloorToInt(highscore).ToString();
        score += pointsPerSecond * Time.deltaTime;
        if (highscore < score)
        {
            PlayerPrefs.SetFloat("highscore", score);
        }
    }
}
