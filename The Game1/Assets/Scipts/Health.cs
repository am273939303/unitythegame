using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Health : MonoBehaviour
{
    [SerializeField] int HealthNumber = 5;
    public Object TheCauseOfDeath;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == TheCauseOfDeath )
        {
            HealthNumber--;
            Debug.Log(HealthNumber);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      
            HealthNumber--;
            Debug.Log(HealthNumber);
        
    }

    private void Update()
    {
        if (HealthNumber == 0)
        {
            Destroy(gameObject);
            Time.deltaTime.Equals(0.2f);
        }
    }
    public void endGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

}

