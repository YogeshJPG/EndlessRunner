using UnityEngine;

public class PreventFlyingObject : MonoBehaviour
{
    Rigidbody rb;

    void Start()
    {
        // Get the Rigidbody component attached to the GameObject
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with another object
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            // Reset the velocity of the Rigidbody to prevent it from flying away
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}
