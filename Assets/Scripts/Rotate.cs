

using UnityEngine;

// This rotates the enemy object
public class Rotate : MonoBehaviour
{

    [SerializeField]
    private float maximumSpinSpeed = 200; // Sets rate of rotation

    // Start is called before the first frame update
    void Start()
    {

        // Applies rate of rotation to object
        GetComponent<Rigidbody2D>().angularVelocity = Random.Range(-maximumSpinSpeed, maximumSpinSpeed);

    }
}
