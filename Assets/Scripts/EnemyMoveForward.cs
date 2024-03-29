

using UnityEngine;


// This gets the enemy to move towards the bottom of the screen
public class EnemyMoveForward : MonoBehaviour {

    private float acceleration = 75f; // Force to apply to enemy

    private float initialVelocity = 2f; // Force to apply when enemy is spawned

    private Rigidbody2D ourRigidbody; // Rigidbody of the enemy

    // Start is called before the first frame update
    void Start()
    {

        // Get and store the Rigidbody component of the enemy
        ourRigidbody = GetComponent<Rigidbody2D>();

        // Set initial velocity of the enemy
        ourRigidbody.velocity = Vector2.down * initialVelocity;

    }

    // Update is called once per frame
    void Update()
    {

        // This defines the speed to apply to the enemy
        Vector2 ForceToAdd = Vector2.down * acceleration * Time.deltaTime;

        // This addsforce to the Rigidbody to move the enemy
        ourRigidbody.AddForce(ForceToAdd);

    }
}
