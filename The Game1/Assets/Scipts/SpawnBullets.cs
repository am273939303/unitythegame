using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnBullets : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject bulletItem;

    [SerializeField] float bulletSpeed;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }

        
    }
    void Shoot()
    {
        GameObject bullet = Instantiate(bulletItem, spawnPoint.position, spawnPoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(spawnPoint.up * bulletSpeed, ForceMode2D.Impulse);
        Destroy(bullet, 5f);

    }
}
