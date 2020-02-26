using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public Transform turret1;
    public Transform turret2;
    public Transform turret3;
    public Transform turret4;
    public Animator turretAnim;
    public Material MatWhite;
    public Material MatDefault;
    SpriteRenderer sr;
    public bool death = false;
    public GameObject bulletPrefab;
    public bool isSpawned;
    public float totalTime = 0f;
    public float shotTime = 0f;
    public float nextFire;
    public float randomFire = 1f;
    public float fireRate = 3f;
    public float turretHealth = 100f;
    public bool deathBlock = false;
    public bool reset = false;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        MatDefault = sr.material;
        GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);

    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        totalTime += Time.deltaTime;
        shotTime += Time.deltaTime;

        if (shotTime > Random.RandomRange(3, 6) && death == false)
        {
            fire();
        }

        if (turretHealth <= 0 && death == false)
        {
            deathAnimation();
        }

        if (death == true)
        {
            Invoke("ResetMaterial", 0.1f);
            destroyTurret();
        }

        else
        {
            Invoke("ResetMaterial", 0.1f);
        }

        if (reset == true)
        {
            resetMaterial();
        }
    }

    public void fire()
    {
        if (isSpawned == false && deathBlock == false)
        {
            Instantiate(bulletPrefab, turret1.position, turret1.rotation);
            Instantiate(bulletPrefab, turret2.position, turret2.rotation);
            Instantiate(bulletPrefab, turret3.position, turret3.rotation);
            Instantiate(bulletPrefab, turret4.position, turret4.rotation);
            shotTime = 0f;
            isSpawned = true;
        }

        else
        {
            isSpawned = false;
            return;
        }
    }

    public void resetMaterial()
    {
        Invoke("ResetMaterial", 0.1f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Missile"))
        {
            Destroy(collision.gameObject);
            turretHealth = turretHealth - 15;
            sr.material = MatWhite;
        }

        if (collision.CompareTag("Laser"))
        {
            Destroy(collision.gameObject);
            turretHealth = turretHealth - 7;
            sr.material = MatWhite;
        }
    }

    public void destroyTurret()
    {
        PlayerScore.playerpoints = PlayerScore.playerpoints + 30;
        Destroy(gameObject);
    }

    public void deathAnimation()
    {
        turretAnim.SetBool("Death", true);
        deathBlock = true;
        Invoke("ResetMaterial", 0.1f);
    }
}