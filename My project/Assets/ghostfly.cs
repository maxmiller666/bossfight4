using UnityEngine;

public class CircleMovement : MonoBehaviour
{
    public float speed = 2f;  
    public Vector3 center = new Vector3(32f, 0.5f, 0f);  

    void Update()
    {
        
        float time = Time.time * 1;
        float x = Mathf.Cos(time) * 6;
        float y = Mathf.Sin(time) * 1;

    
        transform.position = center + new Vector3(x, y, 0);
    }
}