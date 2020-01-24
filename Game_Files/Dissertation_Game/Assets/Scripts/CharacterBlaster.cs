using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterBlaster : MonoBehaviour
{
    public Transform blaster1;
    public Transform blaster2;
    public Transform laser1;
    public Transform laser2;
    public AudioSource laserAudio;
    public AudioSource missileAudio;
    public GameObject missilePrefab;
    public GameObject laserPrefab;
    public Image characterEnergy;
    private bool GamePaused = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (GamePaused == true)
            {
                return;
            }

            else if (GamePaused == false && PlayerHealth.playerHealthNo > 0 && ShootingHealth.ShipEnergy > 0)
            {
                ShootMissile();
            }

        }

        if (Input.GetMouseButton(1))
        {
            if (GamePaused == true)
            {
                return;
            }

            else if (GamePaused == false && PlayerHealth.playerHealthNo > 0 && ShootingHealth.ShipEnergy > 0)
            {
                ShootLaser();
            }
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            GamePaused = true;
        }

        if (GamePaused == true)
        {
            return;
        }
        else 
        {
            if (ShootingHealth.ShipEnergy < ShootingHealth.maxShipEnergy)
            {
                ShootingHealth.ShipEnergy = ShootingHealth.ShipEnergy + 1;
                UpdatePlayerEnergy();
            }

            else
            {
                UpdatePlayerEnergy();
                return;
            }
        }

        Debug.Log("Total Energy" + ShootingHealth.ShipEnergy);
    }

    public void ShootMissile()
    {
        ShootingHealth.ShipEnergy = ShootingHealth.ShipEnergy - 30;
        missileAudio.Play();
        Instantiate(missilePrefab, blaster1.position, blaster1.rotation);
        Instantiate(missilePrefab, blaster2.position, blaster2.rotation);
        UpdatePlayerEnergy();
    }

    public void ShootLaser()
    {
        ShootingHealth.ShipEnergy = ShootingHealth.ShipEnergy - 15;
        laserAudio.Play();
        Instantiate(laserPrefab, laser1.position, laser1.rotation);
        Instantiate(laserPrefab, laser2.position, laser2.rotation);
        UpdatePlayerEnergy();
    }

    private void UpdatePlayerEnergy()
    {
        float ratio = ShootingHealth.ShipEnergy / ShootingHealth.maxShipEnergy;
        characterEnergy.rectTransform.localScale = new Vector3(ratio, 1, 1);
    }

    public void OnPause()
    {
        GamePaused = true;
    }

    public void UnPause()
    {
        GamePaused = false;
    }
}
