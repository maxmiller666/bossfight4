using UnityEngine;

public class CircleMovement : MonoBehaviour
{
    public float speed = 2f;  // Adjust this to change the speed of rotation
    public Vector3 center = new Vector3(32f, 0.5f, 0f);  // Center of the circle

    void Update()
    {
        // Calculate the new position based on the current time and speed
        float time = Time.time * 1;
        float x = Mathf.Cos(time) * 6;
        float y = Mathf.Sin(time) * 3;

        // Update the object's position with an offset for the circle's center
        transform.position = center + new Vector3(x, y, 0);
    }
}