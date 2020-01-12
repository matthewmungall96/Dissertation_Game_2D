using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBlaster : MonoBehaviour
{
    public Transform blaster1;
    public Transform blaster2;
    public AudioSource missileAudio;
    public GameObject missilePrefab;
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

            else if (GamePaused == false)
            {
                missileAudio.Play();
                Shoot();
            }

        }
    }

    void Shoot()
    {
        Instantiate(missilePrefab, blaster1.position, blaster1.rotation);
        Instantiate(missilePrefab, blaster2.position, blaster2.rotation);
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
