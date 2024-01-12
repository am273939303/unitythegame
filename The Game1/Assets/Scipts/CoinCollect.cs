using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public static int score = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            score++;
            Debug.Log(score);
            gameObject.SetActive(false);
        }
    }
    }
