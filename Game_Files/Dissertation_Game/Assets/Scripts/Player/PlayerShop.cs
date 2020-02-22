using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerShop : MonoBehaviour
{
    public Text playerCurrency;
    public GameObject health1Button;
    public GameObject health2Button;
    public GameObject health3Button;
    public GameObject fullHealthButton;
    public GameObject energy1Button;
    public GameObject energy2Button;
    public GameObject energy3Button;
    public GameObject energyMaxButton;
    public GameObject dualLasersButton;
    public GameObject missilesButton;
    public GameObject dualMissilesButton;
    public GameObject lasersFull;
    public GameObject missilesFull;
    public int currency;
    public Text playerHealth;
    public Text playerEnergy;
    public GameObject purchasePanel;
    public GameObject insufficentAmounts;
    public GameObject health1PurchaseB;
    public GameObject health2PurchaseB;
    public GameObject health3PurchaseB;
    public GameObject energy1PurchaseB;
    public GameObject energy2PurchaseB;
    public GameObject energy3PurchaseB;
    public GameObject dualLaserPurchaseB;
    public GameObject missilePurchaseB;
    public GameObject dualMissilePurchaseB;
    public GameObject health1PurchaseT;
    public GameObject health2PurchaseT;
    public GameObject health3PurchaseT;
    public GameObject energy1PurchaseT;
    public GameObject energy2PurchaseT;
    public GameObject energy3PurchaseT;
    public GameObject dualLaserPurchaseT;
    public GameObject missilePurchaseT;
    public GameObject dualMissilePurchaseT;
    void Update()
    {
        currency = PlayerScore.playerpoints;
        playerCurrency.text = "Currency: " + currency;
        playerHealth.text = "Health: " + PlayerHealth.playerHealthMax;
        playerEnergy.text = "Energy: " + ShootingHealth.maxShipEnergy;

        if (PlayerScore.health1 == true)
        {
            health1Button.SetActive(false);
            health2Button.SetActive(true);
        }

        if (PlayerScore.health2 == true)
        {
            health2Button.SetActive(false);
            health3Button.SetActive(true);
        }

        if (PlayerScore.health3 == true)
        {
            health3Button.SetActive(false);
            fullHealthButton.SetActive(true);
        }

        if (PlayerScore.energy1 == true)
        {
            energy1Button.SetActive(false);
            energy2Button.SetActive(true);
        }

        if (PlayerScore.energy2 == true)
        {
            energy2Button.SetActive(false);
            energy3Button.SetActive(true);
        }

        if (PlayerScore.energy3 == true)
        {
            energy3Button.SetActive(false);
            energyMaxButton.SetActive(true);
        }

        if (PlayerScore.dualLasers == true)
        {
            dualLasersButton.SetActive(false);
            lasersFull.SetActive(true);
        }

        if (PlayerScore.missiles == true)
        {
            missilesButton.SetActive(false);
            dualMissilesButton.SetActive(true);
        }

        if (PlayerScore.dualMissiles == true)
        {
            dualMissilesButton.SetActive(false);
            missilesFull.SetActive(true);
        }
    }

    public void testAdd()
    {
        PlayerScore.playerpoints = PlayerScore.playerpoints + 500;
        Debug.Log(PlayerScore.playerpoints);
    }

    public void Health1()
    {
        if (PlayerScore.playerpoints >= 150)
        {
            PlayerHealth.playerHealthMax = PlayerHealth.playerHealthMax + 100;
            PlayerScore.playerpoints = PlayerScore.playerpoints - 150;
            Debug.Log("Health is " + PlayerHealth.playerHealthMax);
            PlayerScore.health1 = true;
            health1PurchaseB.SetActive(false);
            health1PurchaseT.SetActive(false);
            purchasePanel.SetActive(false);
        }

        else
        {
            insufficentAmounts.SetActive(true);
        }
    }

    public void Health2()
    {
        if (PlayerScore.playerpoints >= 250)
        {
            PlayerHealth.playerHealthMax = PlayerHealth.playerHealthMax + 100;
            PlayerScore.playerpoints = PlayerScore.playerpoints - 250;
            Debug.Log("Health is " + PlayerHealth.playerHealthMax);
            PlayerScore.health2 = true;
            health2PurchaseB.SetActive(false);
            health2PurchaseT.SetActive(false);
            purchasePanel.SetActive(false);
        }
        else
        {
            insufficentAmounts.SetActive(true);
        }
    }

    public void Health3()
    {
        if (PlayerScore.playerpoints >= 350)
        {
            PlayerHealth.playerHealthMax = PlayerHealth.playerHealthMax + 100;
            PlayerScore.playerpoints = PlayerScore.playerpoints - 350;
            Debug.Log("Health is " + PlayerHealth.playerHealthMax);
            PlayerScore.health3 = true;
            health3PurchaseB.SetActive(false);
            health3PurchaseT.SetActive(false);
            purchasePanel.SetActive(false);
        }
        else
        {
            insufficentAmounts.SetActive(true);
        }
    }

    public void Energy1()
    {
        if (PlayerScore.playerpoints >= 150)
        {
            ShootingHealth.maxShipEnergy = ShootingHealth.maxShipEnergy + 100;
            PlayerScore.playerpoints = PlayerScore.playerpoints - 150;
            Debug.Log("Energy is " + ShootingHealth.maxShipEnergy);
            PlayerScore.energy1 = true;
            energy1PurchaseB.SetActive(false);
            energy1PurchaseT.SetActive(false);
            purchasePanel.SetActive(false);
        }
        else
        {
            insufficentAmounts.SetActive(true);
        }
    }

    public void Energy2()
    {
        if (PlayerScore.playerpoints >= 250)
        {
            ShootingHealth.maxShipEnergy = ShootingHealth.maxShipEnergy + 100;
            PlayerScore.playerpoints = PlayerScore.playerpoints - 150;
            Debug.Log("Energy is " + ShootingHealth.maxShipEnergy);
            PlayerScore.energy2 = true;
            energy2PurchaseB.SetActive(false);
            energy2PurchaseT.SetActive(false);
            purchasePanel.SetActive(false);
        }
        else
        {
            insufficentAmounts.SetActive(true);
        }
    }

    public void Energy3()
    {
        if (PlayerScore.playerpoints >= 350)
        {
            ShootingHealth.maxShipEnergy = ShootingHealth.maxShipEnergy + 100;
            PlayerScore.playerpoints = PlayerScore.playerpoints - 350;
            Debug.Log("Energy is " + ShootingHealth.maxShipEnergy);
            PlayerScore.energy3 = true;
            energy3PurchaseB.SetActive(false);
            energy3PurchaseT.SetActive(false);
            purchasePanel.SetActive(false);
        }
        else
        {
            insufficentAmounts.SetActive(true);
        }
    }

    public void DualLasers()
    {
        if (PlayerScore.playerpoints >= 100)
        {
            PlayerScore.playerpoints = PlayerScore.playerpoints - 100;
            PlayerScore.dualLasers = true;
            dualLaserPurchaseB.SetActive(false);
            dualLaserPurchaseT.SetActive(false);
            purchasePanel.SetActive(false);
        }
        else
        {
            insufficentAmounts.SetActive(true);
        }
    }

    public void Missiles()
    {
        if (PlayerScore.playerpoints >= 200)
        {
            PlayerScore.playerpoints = PlayerScore.playerpoints - 200;
            PlayerScore.missiles = true;
            missilePurchaseB.SetActive(false);
            missilePurchaseT.SetActive(false);
            purchasePanel.SetActive(false);
        }
        else
        {
            insufficentAmounts.SetActive(true);
        }
    }

    public void DualMissiles()
    {
        if (PlayerScore.playerpoints >= 300)
        {
            PlayerScore.playerpoints = PlayerScore.playerpoints - 300;
            PlayerScore.dualMissiles = true;
            dualMissilePurchaseB.SetActive(false);
            dualMissilePurchaseT.SetActive(false);
            purchasePanel.SetActive(false);
        }
        else
        {
            insufficentAmounts.SetActive(true);
        }
    }
}
