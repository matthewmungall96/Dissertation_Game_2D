using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDamageManager : MonoBehaviour
{
    public Image playerHealthBar;
    public GameObject PlayerDeathScreen;
    void Update()
    {
        UpdatePlayerHealth();

        if (PlayerHealth.playerHealthNo == 0)
        {
            PlayerDeath();
        }
    }

    private void UpdatePlayerHealth()
    {
        float ratio = PlayerHealth.playerHealthNo / PlayerHealth.playerHealthMax;
        playerHealthBar.rectTransform.localScale = new Vector3(ratio, 1, 1);
      
    }

    public void TakeDamage()
    {
        if(PlayerHealth.playerHealthNo > 0)
        {
            PlayerHealth.playerHealthNo = PlayerHealth.playerHealthNo - 10;
            Debug.Log("Player Health is " + PlayerHealth.playerHealthNo);
            UpdatePlayerHealth();
        }

        else
        {
            Debug.Log("Player has died!");
            return;
        }

    }

    public void PlayerDeath()
    {
        PlayerDeathScreen.SetActive(true);
    }
}
