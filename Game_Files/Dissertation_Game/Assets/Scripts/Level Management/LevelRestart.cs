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
        PlayerHealth.playerHealthNo = 150;
        ShootingHealth.ShipEnergy = 200f;
        PlayerHealth.playerHasDied = false;
        ship.SetBool("IsDead", false);
        GameOverMenu.SetActive(false);
        SceneManager.LoadScene("2.1. Mars");
    }

    public void RestartMars2()
    {
        PlayerHealth.playerHealthNo = 150;
        ShootingHealth.ShipEnergy = 200f;
        PlayerHealth.playerHasDied = false;
        GameOverMenu.SetActive(false);
        SceneManager.LoadScene("2.2. Mars");
    }

    public void RestartMars3()
    {
        PlayerHealth.playerHealthNo = 150;
        ShootingHealth.ShipEnergy = 200f;
        PlayerHealth.playerHasDied = false;
        GameOverMenu.SetActive(false);
        SceneManager.LoadScene("2.3. Mars");
    }

    public void RestartMarsBoss()
    {
        PlayerHealth.playerHealthNo = 150;
        ShootingHealth.ShipEnergy = 200f;
        PlayerHealth.playerHasDied = false;
        GameOverMenu.SetActive(false);
        SceneManager.LoadScene("3.B. Mars");
    }

    public void RestartJupiter1()
    {
        PlayerHealth.playerHealthNo = 150;
        ShootingHealth.ShipEnergy = 200f;
        PlayerHealth.playerHasDied = false;
        GameOverMenu.SetActive(false);
        SceneManager.LoadScene("3.1. Jupiter");
    }
    public void RestartJupiter2()
    {
        PlayerHealth.playerHealthNo = 150;
        ShootingHealth.ShipEnergy = 200f;
        PlayerHealth.playerHasDied = false;
        GameOverMenu.SetActive(false);
        SceneManager.LoadScene("3.2. Jupiter");
    }
    public void RestartJupiter3()
    {
        PlayerHealth.playerHealthNo = 150;
        ShootingHealth.ShipEnergy = 200f;
        PlayerHealth.playerHasDied = false;
        GameOverMenu.SetActive(false);
        SceneManager.LoadScene("3.3. Jupiter");
    }
    public void RestartJupiterBoss()
    {
        PlayerHealth.playerHealthNo = 150;
        ShootingHealth.ShipEnergy = 200f;
        PlayerHealth.playerHasDied = false;
        GameOverMenu.SetActive(false);
        SceneManager.LoadScene("3.B. Jupiter");
    }

    public void RestartVenus1()
    {
        PlayerHealth.playerHealthNo = 150;
        ShootingHealth.ShipEnergy = 200f;
        PlayerHealth.playerHasDied = false;
        GameOverMenu.SetActive(false);
        SceneManager.LoadScene("4.1. Venus");
    }

    public void RestartVenus2()
    {
        PlayerHealth.playerHealthNo = 150;
        ShootingHealth.ShipEnergy = 200f;
        PlayerHealth.playerHasDied = false;
        GameOverMenu.SetActive(false);
        SceneManager.LoadScene("4.2. Venus");
    }
    public void RestartVenus3()
    {
        PlayerHealth.playerHealthNo = 150;
        ShootingHealth.ShipEnergy = 200f;
        PlayerHealth.playerHasDied = false;
        GameOverMenu.SetActive(false);
        SceneManager.LoadScene("4.3. Venus");
    }
    public void RestartVenusBoss()
    {
        PlayerHealth.playerHealthNo = 150;
        ShootingHealth.ShipEnergy = 200f;
        PlayerHealth.playerHasDied = false;
        GameOverMenu.SetActive(false);
        SceneManager.LoadScene("4.B. Venus");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("1. Main Menu");
    }
}
