using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Health : MonoBehaviour
{
    [SerializeField] int HealthNumber1 = 5;

   
  

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ProccesCollisions(collision.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        ProccesCollisions(collision.gameObject);
    }

    private void ProccesCollisions(GameObject collisions)
    {
        if(collisions.gameObject.CompareTag("Enemy"))
        {
            HealthNumber1--;
            Debug.Log(gameObject + "Has Lost Damage:" + HealthNumber1);

        }
    }

    private void Update()
    {
        if (HealthNumber1 == 0)
        {
            Destroy(gameObject);
            Time.deltaTime.Equals(0.2f);
            endGame();
        }
    }
    public void endGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

}

