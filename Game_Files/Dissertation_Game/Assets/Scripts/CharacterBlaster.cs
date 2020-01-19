using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

            else if (GamePaused == false && PlayerHealth.playerHealthNo > 0)
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

            else if (GamePaused == false)
            {
                laserAudio.Play();
                ShootLaser();
            }
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            GamePaused = true;
        }
    }

    public void ShootMissile()
    {
        missileAudio.Play();
        Instantiate(missilePrefab, blaster1.position, blaster1.rotation);
        Instantiate(missilePrefab, blaster2.position, blaster2.rotation);
    }

    void ShootLaser()
    {
        Instantiate(laserPrefab, laser1.position, laser1.rotation);
        Instantiate(laserPrefab, laser2.position, laser2.rotation);
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
