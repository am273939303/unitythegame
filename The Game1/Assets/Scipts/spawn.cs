using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject prefab1; // First prefab to spawn
    public GameObject prefab2; // Second prefab to spawn
    public GameObject prefab3; // Third prefab to spawn

    void Start()
    {
       
        SpawnPrefabs();
    }

    void SpawnPrefabs()
    {
    
        Vector2 spawnPosition1 = new Vector2(-2.0f, 0.0f);
        Vector2 spawnPosition2 = new Vector2(0.0f, 0.0f);
        Vector2 spawnPosition3 = new Vector2(2.0f, 0.0f);

       
        Instantiate(prefab1, spawnPosition1, Quaternion.identity);
        Instantiate(prefab2, spawnPosition2, Quaternion.identity);
        Instantiate(prefab3, spawnPosition3, Quaternion.identity);
    }
}