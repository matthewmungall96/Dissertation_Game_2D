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
    public AudioClip laser;
    public GameObject missilePrefab;
    public GameObject laserPrefab;
    public static float energy = 1f;
    public Image characterEnergy;
    private bool GamePaused = false;
    public bool isDead = false;
    private 
    // Update is called once per frame
    void Update()
    {
        UpdatePlayerEnergy();
        if (isDead == true)
        {
            Destroy(gameObject);
        }
        if (isDead == false && PlayerDamageManager.weaponsDisabled == false)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                if (GamePaused == true)
                {
                    return;
                }

                else if (GamePaused == false && PlayerHealth.playerHealthNo > 0 && ShootingHealth.ShipEnergy >= 30)
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

                else if (GamePaused == false && PlayerHealth.playerHealthNo > 0 && ShootingHealth.ShipEnergy >= 10)
                {
                    ShootLaser();
                }
            }

                if (ShootingHealth.ShipEnergy < ShootingHealth.maxShipEnergy && GamePaused == false)
                {
                    ShootingHealth.ShipEnergy = ShootingHealth.ShipEnergy + energy;
                    UpdatePlayerEnergy();
                }

                else
                {
                    UpdatePlayerEnergy();
                    return;
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
    }

    public void ShootMissile()
    {
        if (PlayerScore.missiles == true)
        {
            if (PlayerScore.dualMissiles == true)
            {
                ShootingHealth.ShipEnergy = ShootingHealth.ShipEnergy - 30;
            }
            else
            {
                ShootingHealth.ShipEnergy = ShootingHealth.ShipEnergy - 15;
            }
            missileAudio.Play();
            Instantiate(missilePrefab, blaster1.position, blaster1.rotation);
            if (PlayerScore.dualMissiles == true)
            {
                Instantiate(missilePrefab, blaster2.position, blaster2.rotation);
            }
            UpdatePlayerEnergy();
        }
    }

    public void ShootLaser()
    {
        if (PlayerScore.dualLasers == false)
        {
            ShootingHealth.ShipEnergy = ShootingHealth.ShipEnergy - 7;
        }

        else
        {
            ShootingHealth.ShipEnergy = ShootingHealth.ShipEnergy - 15;
        }

        laserAudio.PlayOneShot(laser);
        Instantiate(laserPrefab, laser1.position, laser1.rotation);
        if (PlayerScore.dualLasers == true)
        {
          Instantiate(laserPrefab, laser2.position, laser2.rotation);
        }
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
