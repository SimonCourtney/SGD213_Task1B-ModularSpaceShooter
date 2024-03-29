

using UnityEngine;

// This gets the bullet to move towards its target
public class BulletMoveForward : MonoBehaviour {

    private float acceleration = 50f; // Force to apply to bullet

    private float initialVelocity = 5f; // Force to apply when bullet is spawned

    private Rigidbody2D ourRigidbody; // Rigidbody of the bullet

    // Start is called before the first frame update
    void Start()
    {

        // Get and store the Rigidbody component for the bullet
        ourRigidbody = GetComponent<Rigidbody2D>();

        // Set initial velocity of the bullet
        ourRigidbody.velocity = Vector2.up * initialVelocity;

    }

    // Update is called once per frame
    void Update()
    {

        // This defines the speed to apply to the bullet
        Vector2 ForceToAdd = Vector2.up * acceleration * Time.deltaTime;

        // This addsforce to the Rigidbody to move the bullet
        ourRigidbody.AddForce(ForceToAdd);

    }
}
