using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Health : MonoBehaviour
{
    [SerializeField] int HealthNumber1 = 5;
    public Object TheCauseOfDeath;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == TheCauseOfDeath )
        {
            HealthNumber1--;
            Debug.Log(HealthNumber1);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      
            HealthNumber1--;
            Debug.Log(HealthNumber1);
        
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

