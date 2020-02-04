using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelRestart : MonoBehaviour
{
    public GameObject GameOverMenu;
    public Animator ship;

    public void RestartMars1()
    {
        PlayerHealth.playerHealthNo = PlayerHealth.playerHealthMax;
        ShootingHealth.ShipEnergy = ShootingHealth.maxShipEnergy;
        Boss_Health.NoszinaaHealth = Boss_Health.NoszinaaMaxHealth;
        PlayerHealth.playerHasDied = false;
        ship.SetBool("IsDead", false);
        GameOverMenu.SetActive(false);
        SceneManager.LoadScene("2.1. Mars");
    }

    public void RestartMars2()
    {
        PlayerHealth.playerHealthNo = PlayerHealth.playerHealthMax;
        ShootingHealth.ShipEnergy = ShootingHealth.maxShipEnergy;
        Boss_Health.LioskohaaHealth = Boss_Health.LioskohaaMaxHealth;
        PlayerHealth.playerHasDied = false;
        GameOverMenu.SetActive(false);
        SceneManager.LoadScene("2.2. Mars");
    }

    public void RestartMarsBoss()
    {
        PlayerHealth.playerHealthNo = PlayerHealth.playerHealthMax;
        ShootingHealth.ShipEnergy = ShootingHealth.maxShipEnergy;
        Boss_Health.SpectroHealth = Boss_Health.SpectroMaxHealth;
        PlayerHealth.playerHasDied = false;
        GameOverMenu.SetActive(false);
        SceneManager.LoadScene("2.B. Mars");
    }

    public void RestartJupiter1()
    {
        PlayerHealth.playerHealthNo = PlayerHealth.playerHealthMax;
        ShootingHealth.ShipEnergy = ShootingHealth.maxShipEnergy;
        Boss_Health.WounsursHealth = Boss_Health.WounsursMaxHealth;
        PlayerHealth.playerHasDied = false;
        GameOverMenu.SetActive(false);
        SceneManager.LoadScene("3.1. Jupiter");
    }
    public void RestartJupiter2()
    {
        PlayerHealth.playerHealthNo = PlayerHealth.playerHealthMax;
        ShootingHealth.ShipEnergy = ShootingHealth.maxShipEnergy;
        Boss_Health.SoleilHealth = Boss_Health.SoleilMaxHealth;
        PlayerHealth.playerHasDied = false;
        GameOverMenu.SetActive(false);
        SceneManager.LoadScene("3.2. Jupiter");
    }
    public void RestartJupiterBoss()
    {
        PlayerHealth.playerHealthNo = PlayerHealth.playerHealthMax;
        ShootingHealth.ShipEnergy = ShootingHealth.maxShipEnergy;
        Boss_Health.HeohummHealth = Boss_Health.HeohummMaxHealth;
        PlayerHealth.playerHasDied = false;
        GameOverMenu.SetActive(false);
        SceneManager.LoadScene("3.B. Jupiter");
    }

    public void RestartVenus1()
    {
        PlayerHealth.playerHealthNo = PlayerHealth.playerHealthMax;
        ShootingHealth.ShipEnergy = ShootingHealth.maxShipEnergy;
        Boss_Health.PranoordeHealth = Boss_Health.PranoordeMaxHealth;
        PlayerHealth.playerHasDied = false;
        GameOverMenu.SetActive(false);
        SceneManager.LoadScene("4.1. Venus");
    }

    public void RestartVenus2()
    {
        PlayerHealth.playerHealthNo = PlayerHealth.playerHealthMax;
        ShootingHealth.ShipEnergy = ShootingHealth.maxShipEnergy;
        Boss_Health.VaeklaszoHealth = Boss_Health.VaeklaszoMaxHealth;
        PlayerHealth.playerHasDied = false;
        GameOverMenu.SetActive(false);
        SceneManager.LoadScene("4.2. Venus");
    }
    public void RestartVenusBoss()
    {
        PlayerHealth.playerHealthNo = PlayerHealth.playerHealthMax;
        ShootingHealth.ShipEnergy = ShootingHealth.maxShipEnergy;
        Boss_Health.GriraxHealth = Boss_Health.GriraxMaxHealth;
        PlayerHealth.playerHasDied = false;
        GameOverMenu.SetActive(false);
        SceneManager.LoadScene("4.B. Venus");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("1. Main Menu");
    }
}
