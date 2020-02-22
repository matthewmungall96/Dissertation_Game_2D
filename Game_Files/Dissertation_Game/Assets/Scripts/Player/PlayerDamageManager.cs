using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDamageManager : MonoBehaviour
{
    public Image playerHealthBar;
    public GameObject PlayerDeathScreen;
    public Animator shipExplosion;
    private int timesDied = 0;
    void Update()
    {
        UpdatePlayerHealth();

        if (PlayerHealth.playerHealthNo <= 0 && PlayerHealth.playerHasDied == false)
        {
            PlayerDeath();
            Debug.Log("Times Died " + timesDied++);
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
            return;
        }

    }

    public void WrongAnswer()
    {
        PlayerHealth.playerHealthNo = PlayerHealth.playerHealthNo / 100 * 50;
    }

    public void PlayerDeath()
    {
        PlayerHealth.playerHasDied = true;
        shipExplosion.SetBool("IsDead", true);
        PlayerDeathScreen.SetActive(true);
        StartCoroutine(PlayerDestroy());
    }

    IEnumerator PlayerDestroy()
    {
        yield return new WaitForSeconds(0);
        Destroy(gameObject);
    }
}
