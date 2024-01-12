using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] GameObject Enemy;
    [SerializeField] int HowManyEnemys;
    private void Start()
    {
        StartCoroutine(SpawnEnemys());
    }
    IEnumerator SpawnEnemys()
    {
        for (int i = 0; i < HowManyEnemys; i++)
        {
            yield return new WaitForSeconds(5);
            var position = new Vector2(Random.Range(-8, 8), Random.Range(-4, 4));
            Instantiate(Enemy, position, Quaternion.identity);
            Debug.Log("Finished Coroutine at timestamp : " + Time.time);
        }
       
    }
}
