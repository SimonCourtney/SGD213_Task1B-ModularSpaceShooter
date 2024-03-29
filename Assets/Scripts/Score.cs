

using UnityEngine;
using TMPro;

// This tracks the number of enemy objects a player has destroyed
public class Score : MonoBehaviour
{

    [SerializeField]
    private TextMeshProUGUI scoreText; // Variable to display score

    private int score; // Variable to keep track of score

    // Start is called before the first frame update
    private void Start()
    {

        score = 0; // Initialises the score to zero

        SetScoreText(); // Update the score display

    }

    // Called by DestroyedOnCollision
    public void changeScore(int scoreChange)
    {

        // Increases the score by the increment value recived from DestroyedOnCollision
        score += scoreChange;

        SetScoreText(); // Updates the score display

    }

    // Displays the score
    void SetScoreText()
    {

        // Update the score text with the current score.
        scoreText.text = "Score: " + score.ToString();

    }
}
