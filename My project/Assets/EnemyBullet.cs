using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private GameObject player;
    private Rigidbody2D rb;
    public float force;
    public Transform tplayer;
    public Vector3 targetPosition = new Vector3(32.58f, 0f, 0f);
    private bool shouldMove = true;


    // Start is called before the first frame update
    void Start()
    {
        

        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");

        Vector3 direction = player.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;

        float rot = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot + 180);
    }

    // Update is called once per frame
    void Update()
    {
        if (tplayer.position.x > 20f)
        {
        
            shouldMove = false;
        }
        if (shouldMove)
        {
            transform.position = targetPosition;
        }
    }
}
