using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float speed = 2.0f; // Adjust this to control the speed of the object
    bool moveRight = true;
    float leftBoundary = 4.83f; // Starting X position - 5 (assuming the object starts at 9.83)
    float rightBoundary = 14.83f; // Starting X position + 5 (assuming the object starts at 9.83)
    private float horizontal;




    void Start()
    {
        leftBoundary = transform.position.x - 2.0f; // Define left boundary based on starting position
        rightBoundary = transform.position.x + 2.0f; // Define right boundary based on starting position
    }

    void Update()
    {
        if (moveRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime); // Moves to the right
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime); // Moves to the left
        }

        if (transform.position.x >= rightBoundary)
        {
            moveRight = false; // If it reaches the right boundary, move left
        }
        else if (transform.position.x <= leftBoundary)
        {
            moveRight = true; // If it reaches the left boundary, move right
        }


    }


}
