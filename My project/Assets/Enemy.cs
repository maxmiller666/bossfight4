using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 100;
    int currentHealth;
    public Transform player;
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    public float bulletSpeed = 5f;
    public float followSpeed = 2f;
    public Vector3 triggerPosition = new Vector3(24.74264f, -4.077972f, -10f);
    public float repeatInterval = 2f;  // Time interval between repeated shots
    private float lastShootTime;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        // Follow the player
        transform.position = Vector2.MoveTowards(transform.position, player.position, followSpeed * Time.deltaTime);

        // Check if the player is at the trigger position
        if (player.position == triggerPosition && Time.time - lastShootTime > repeatInterval)
        {
            // Shoot at the player
            ShootAtPlayer();

            // Update the last shoot time
            lastShootTime = Time.time;
        }
    }

    void ShootAtPlayer()
    {
        // Instantiate a bullet
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);

        // Calculate the direction to the player
        Vector2 direction = (player.position - bulletSpawnPoint.position).normalized;

        // Set the bullet's velocity
        bullet.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;

        // Destroy the bullet after 1 second
        Destroy(bullet, 1f);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if(currentHealth <= 0)
        {
            Die();
        }
    }
    
    void Die()
    {
        Debug.Log("Enemy died");
        Destroy(gameObject);
    }

}


    

