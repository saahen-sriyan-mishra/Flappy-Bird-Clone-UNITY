using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D body;
    public float forceValue = 20f;
    public float maxVerticalVelocity = 10f; // Adjust this value as needed

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        if (body == null)
        {
            Debug.LogError("Rigidbody2D component is missing from the bird GameObject.");
        }
    }

    void Update()
    {
        if (GameManager.isPlaying && (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)))
        {
            // Apply force only if the bird is moving downwards (prevents excessive jumping when holding the mouse button)
            if (body.velocity.y <= 0)
            {
                body.velocity = Vector2.zero;  // Reset the velocity to have consistent force application
                body.AddForce(Vector2.up * forceValue, ForceMode2D.Impulse);
            }
        }

        // Limit vertical velocity
        if (body.velocity.y > maxVerticalVelocity)
        {
            body.velocity = new Vector2(body.velocity.x, maxVerticalVelocity);
        }

        // Ensure y-position check logic is correct (both should be the same comparison)
        if (transform.position.y > 1.15f || transform.position.y < -1.15f)
        {
            Debug.Log("Bird out of bounds. Stopping the game.");
            GameManager.isPlaying = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Bird collided with an object. Stopping the game.");
        GameManager.isPlaying = false;
    }
}
