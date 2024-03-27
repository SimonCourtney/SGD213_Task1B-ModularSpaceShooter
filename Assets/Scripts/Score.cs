using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI scoreText;
    public static Score instance;
    private int score;

    private void Start()
    {
        score = 0;
        SetScoreText();
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void changeScore(int scoreChange)
    {
        score += scoreChange;
        SetScoreText();
    }

    void SetScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
