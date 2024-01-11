using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public static int score;
    // Start is called before the first frame update
    void Update()
    {
        score = CoinCollect.score;
        scoreText.text = score.ToString();
    }

}
