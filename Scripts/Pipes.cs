using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed = 5f;
    private float leftEdge;

    private void Start()
    {
        // Calculate the left edge of the screen based on the camera's viewport
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f; // Adjust the -1f as needed for your game
    }

    private void Update()
    {
        // Move the pipes to the left
        transform.position += Vector3.left * speed * Time.deltaTime;

        // Check if the pipes are out of view
        if (transform.position.x < leftEdge)
        {
            // Reset the position of the pipes to the right side of the screen
            Destroy(gameObject);
        }
    }
}
