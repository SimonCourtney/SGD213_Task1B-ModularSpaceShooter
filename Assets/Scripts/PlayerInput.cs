

using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    private ShootingScript shootingScript; // Sets script as variable type

    private PlayerMovementScript playerMovementScript; // Sets script as variable type  

    // Start is called before the first frame update
    void Start()
    {

        shootingScript = FindObjectOfType<ShootingScript>(); // Assigns script to a variable

        playerMovementScript = FindObjectOfType<PlayerMovementScript>(); // Assigns script to a variable

    }

    // Update is called once per frame
    void Update()
    {

        float HorizontalInput = Input.GetAxis("Horizontal"); // Gets input from controller

        
        // Checks for input from player left/right controls
        if (HorizontalInput != 0.0f)
        {
            playerMovementScript.MovePlayer(HorizontalInput); // Moves player object left and right
            
        }

        // Checks for input from player fire button
        if (Input.GetButton("Fire1"))
        {

            shootingScript.FireWeapon(); // Fires weapon

        }
    }
}
