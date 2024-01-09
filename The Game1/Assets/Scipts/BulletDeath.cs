using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDeath : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Player" && collision.gameObject.tag != "Bullet")
        {
            gameObject.SetActive(false);

        } 
  

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag != "Player" && collision.gameObject.tag != "Bullet")
        {
            gameObject.SetActive(false);

        }
   
        
    }
}
