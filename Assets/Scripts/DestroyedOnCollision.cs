

using UnityEngine;
using System.Collections.Generic;

// Sets the names for the tags
// A list of tags which we use to determine whether to explode or not
// Depending on the tagListType (Blacklist or Whitelist)
public enum TagListType
{
    Blacklist,
    Whitelist
}

// This handles collisions between objects
public class DestroyedOnCollision : MonoBehaviour
{
    [SerializeField]
    private TagListType tagListType = TagListType.Blacklist;

    [SerializeField]
    private List<string> tags;

    // Detects if there is a collision
    void OnTriggerEnter2D(Collider2D other)
    {

        bool tagInList = tags.Contains(other.gameObject.tag);

        // Checks if Player has collided with a Blacklist object
        if (tagListType == TagListType.Blacklist 
            && tagInList)
        {

            // Destroy if it's a Blacklist and the tag IS in the Blacklist
            Destroy(gameObject);

            if (gameObject.tag == "Player")
            {

                // This displays the 'Game Over!' text when player is destroyed
                EndGame.instance.endGame();

            }

        }
        else if (tagListType == TagListType.Whitelist 
            && !tagInList)
        {

            // Destroy if it's a Whitelist and the tag is NOT in the Whitelist
            Destroy(gameObject);

            if (gameObject.tag == "Player")
            {

                // This adds 1 to the score when an enemy is destroyed
                Score.instance.changeScore(1); 

            }
        }
    }
}
