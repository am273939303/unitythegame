using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDeath : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.SetActive(false);
    }
}
