

using UnityEngine;

// This moves the Player object: Left and Right
public class PlayerMovementScript : MonoBehaviour 
{

            [SerializeField]
            private float playerAcceleration = 5000f; // Force to apply to player object

            private Rigidbody2D ourRigidBody; // Rigidbody of the player object

    // Start is called before the first frame update
    void Start() 
    {

        /// Get and store the Rigidbody component of the enemy
        ourRigidBody = GetComponent<Rigidbody2D>(); 

    }


    // Update is called once per frame
    void Update() 
    {

        float HorizontalInput = Input.GetAxis("Horizontal"); // Gets input from controller

        // Checks for input from player controls
        if (HorizontalInput != 0.0f) 

        {

            // This defines the speed to apply to the player object
            Vector2 ForceToAdd = Vector2.right*HorizontalInput*playerAcceleration*Time.deltaTime;

            // This addsforce to the Rigidbody to move the player object
            ourRigidBody.AddForce(ForceToAdd);

        } 
    } 
}
