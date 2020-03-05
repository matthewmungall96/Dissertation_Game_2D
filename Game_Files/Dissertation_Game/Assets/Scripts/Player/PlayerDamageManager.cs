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
    public static bool isDisabled;
    public static bool isDisabledLioskohaa;
    public static bool isDisabledWounsurs;
    public static bool isDisabledHeohumm;
    public static bool isDisabledSpectro;
    public static bool weaponsDisabled;
    public static float weaponsDisabledTime;
    public static float disabledTime;
    void Update()
    {
        UpdatePlayerHealth();

        if (isDisabled == true && isDisabledLioskohaa == true)
        {
            disabledTime += Time.deltaTime;
            if (disabledTime >= 10)
            {
                isDisabledLioskohaa = false;
                isDisabled = false;
            }
        }

        if (isDisabled == true && isDisabledWounsurs == true)
        {
            disabledTime += Time.deltaTime;
            if (disabledTime >= 15)
            {
                isDisabled = false;
            }
        }

        if (weaponsDisabled == true && isDisabledSpectro == true)
        {
            weaponsDisabledTime += Time.deltaTime;
            if (weaponsDisabledTime >= 10)
            {
                weaponsDisabled = false;
            }
        }

        if (isDisabled == true && isDisabledHeohumm == true)
        {
            disabledTime += Time.deltaTime;
            weaponsDisabledTime += Time.deltaTime;
            if (disabledTime >= 20 && weaponsDisabledTime >= 20)
            {
                isDisabled = false;
                weaponsDisabled = false;
            }
        }

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

    public void WrongAnswerNoszinaa()
    {
        PlayerHealth.playerHealthNo = PlayerHealth.playerHealthNo / 100 * 50;
    }

    public void WrongAnswerLioskohaa()
    {
        isDisabledLioskohaa = true;
        isDisabled = true;
    }

    public void WrongAnswerSpectro()
    {
        isDisabledSpectro = true;
        weaponsDisabled = true;
    }

    public void WrongAnswerWounsurs()
    {
        isDisabled = true;
        isDisabledWounsurs = true;
    }

    public void WrongAnswerSoleil()
    {
        PlayerHealth.playerHealthNo = PlayerHealth.playerHealthNo = 0;
    }

    public void WrongAnswerHeohumm()
    {
        isDisabledHeohumm = true;
        weaponsDisabled = true;
        isDisabled = true;
    }


}
