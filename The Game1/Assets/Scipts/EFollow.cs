using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EFollow : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody2D enemyRb;
    private GameObject player;
    public logicmanager logic;

    
    void Start()
    {
        enemyRb = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicmanager>();

    }
    private void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }


    void FixedUpdate()
    {
        MoveTowardsPlayer();
    }

    void MoveTowardsPlayer()
    {
        if (player != null)
        {
            Vector2 lookDirection = (player.transform.position - transform.position).normalized;
            enemyRb.velocity = new Vector2(lookDirection.x * speed, lookDirection.y * speed);
        }
    }
}