using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    public float score = 0;
    public int pointsPerSecond = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = Mathf.FloorToInt(score).ToString();
        score += pointsPerSecond * Time.deltaTime;
    }
}
