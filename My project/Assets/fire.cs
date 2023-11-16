using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject fire1;
    public Transform firePos;

    private float timer;
    private GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        

        float distance = Vector2.Distance(transform.position, player.transform.position);

        if(distance < 13)
        {
            timer += Time.deltaTime;

            if (timer > 2)
            {
                timer = 0;
                shoot();
            }
        }

        
    }

    void shoot()
    {
        Instantiate(fire1, firePos.position, Quaternion.identity);
    }

}