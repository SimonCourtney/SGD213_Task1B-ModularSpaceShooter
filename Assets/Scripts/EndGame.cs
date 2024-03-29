

using UnityEngine;

// This displays the 'Game Over!' text when player is destroyed
public class EndGame : MonoBehaviour
{

    // UI text to display 'Game Over!' text
    public GameObject endTextObject;

    // Start is called before the first frame update
    void Start()
    {

        // Hides the 'Game Over!' text at the start of the game
        endTextObject.SetActive(false);

    }

    // Called by DestroyedOnCollision
    public void endGame()
    {

        // Displays the 'Game Over!' text when player is destroyed
        endTextObject.SetActive(true);

    }
}
