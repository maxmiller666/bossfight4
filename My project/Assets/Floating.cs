using UnityEngine;

public class FloatAndRotate : MonoBehaviour
{
    public float floatSpeed = 1.0f;
    public float rotationSpeed = 50.0f;
  

    void Update()
    {
        // Float up
        Vector3 newPosition = transform.position;
        newPosition.y += Mathf.Sin(Time.time * floatSpeed) * 0.004f;
        transform.position = newPosition;

        // Rotate
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}
