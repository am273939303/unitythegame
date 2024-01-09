using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class logicmanager : MonoBehaviour
{
    public int playerHealth;
    public Text healthText;

    [ContextMenu("Decreace Health")]
    public void subtractHealth()
        {
        playerHealth = playerHealth - 1;
        healthText.text = playerHealth.ToString();
        }
}
