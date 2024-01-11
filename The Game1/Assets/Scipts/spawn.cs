using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawn : MonoBehaviour
{
    public GameObject prefab1; // First prefab to spawn
    public GameObject prefab2; // Second prefab to spawn
    public string sceneToCheck;

    void Start()
    {
        if (SceneManager.GetActiveScene().name == sceneToCheck)
        {
            SpawnPrefabs();
           
        }
    }

    void SpawnPrefabs()
    {
        
        Vector2 spawnPosition1 = new Vector2(-2.0f, 0.0f);
        Vector2 spawnPosition2 = new Vector2(2.0f, 0.0f);

        
        Instantiate(prefab1, spawnPosition1, Quaternion.identity);
        Instantiate(prefab2, spawnPosition2, Quaternion.identity);
    }
}