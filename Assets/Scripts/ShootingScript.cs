

using UnityEngine;

// Called when player fires weapon
public class ShootingScript : MonoBehaviour
{

    [SerializeField]
    private GameObject bullet; // Declares varible for bullet

    private float lastFiredTime = 0f; // Used to control firing rate

    [SerializeField]
    private float fireDelay = 1f; // Set the delay between shots

    private float bulletOffset = 2f; // Distance from player object

    // Start is called before the first frame update
    void Start()
    {

        // Ensure bullet spawns in front of player object
        bulletOffset = GetComponent<Renderer>().bounds.size.y / 2 // Half of our size
            + bullet.GetComponent<Renderer>().bounds.size.y / 2; // Plus half of the bullet size

    }

    // Update is called once per frame
    void Update()
    {
        // Checks for input form player controller
        if (Input.GetButton("Fire1"))
        {

            float CurrentTime = Time.time; // Records time bullet was fired

            // Have a delay so we don't shoot too many bullets
            if (CurrentTime - lastFiredTime > fireDelay)
            {
                // Ensure bullet appears in front of player object
                Vector2 spawnPosition = new Vector2(transform.position.x, transform.position.y + bulletOffset);

                Instantiate(bullet, spawnPosition, transform.rotation); // Creates bullet

                lastFiredTime = CurrentTime; // Records time bullet was fired
            }
        }
    }
}
