using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EFollow : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private GameObject player;
   

    [SerializeField] private float LookRange;
     private float Distance;
    
    void Start()
    {
      
    
    }

    void FixedUpdate()
    {
        MoveTowardsPlayer();
    }

    void MoveTowardsPlayer()
    {
            Distance = Vector2.Distance(transform.position, player.transform.position);
            Vector2 lookDirection = player.transform.position - transform.position;
            lookDirection.Normalize();
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;

        if (Distance < LookRange)
            {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
                transform.rotation = Quaternion.Euler(Vector3.forward * angle);
            } 

    }

    
}