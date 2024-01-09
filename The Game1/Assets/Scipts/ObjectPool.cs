using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{

    public static ObjectPool Pool;

    private List<GameObject> pooledObjects = new List<GameObject>();
    private int amountToPool = 20;

    [SerializeField] private GameObject bulletPre;

    private void Awake()
    {
        if (Pool == null)
        {
            Pool = this;
        }
    }

    private void Start()
    {
        for(int i = 0; i < amountToPool; i++)
        {
            GameObject obj = Instantiate(bulletPre);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }

        }
        return null;
    }
}
