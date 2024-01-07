using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int HealthNumber = 5;
    public GameObject TheCauseOfDeath;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == TheCauseOfDeath)
        {
            Debug.Log("You've been hit");
            HealthNumber--;
            Debug.Log(HealthNumber);
        }
    }

    private void Update()
    {
        if (HealthNumber == 0f)
        {
            Destroy(gameObject);
        }
    }

}

