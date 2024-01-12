using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemeyHealth : MonoBehaviour
{
    [SerializeField] int HealthNumber = 5;
 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        ProccessColliders(collision.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ProccessColliders(collision.gameObject);
    }

    private void ProccessColliders(GameObject collisions)
    {
        if (collisions.gameObject.CompareTag("Bullet"))
        {
            HealthNumber--;
            Debug.Log(gameObject + "Has Lost Damage:" + HealthNumber);

        }
    }

    private void Update()
    {
        if (HealthNumber == 0)
        {
            Destroy(gameObject);
            Time.deltaTime.Equals(0.2f);
  
        }
    }
}
