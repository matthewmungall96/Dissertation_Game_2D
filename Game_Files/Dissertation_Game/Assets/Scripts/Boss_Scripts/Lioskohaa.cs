using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Lioskohaa : MonoBehaviour
{
    public GameObject LioskohaaFightUi;
    public Image LioskohaaHealthBar;
    public Animator LioskohaaAnim;
    public Material MatWhite;
    private Material MatDefault;
    SpriteRenderer sr;
    private bool death = false;
    public bool trigger_once;
    private bool isTriggered;
    public Transform blaster;
    public AudioClip laser;
    public AudioSource laserSource;
    public GameObject missilePrefab;
    public GameObject winScreen;
    public float totalTime = 0f;
    public float shotTime = 0f;
    public float nextFire;
    public float randomFire = 1f;
    public float fireRate = 3f;
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

        if (totalTime > 2.5 && totalTime < 3)
        {

        }

        if ((totalTime > 3) && (GetComponent<Transform>().position.y > 3) && death == false)
        {
            fire();
            LioskohaaAnim.SetBool("Move_Down", true);
            LioskohaaAnim.SetBool("Move_Up", false);
        }

        if ((totalTime > 3) && (GetComponent<Transform>().position.y < -3) && death == false)
        {
            LioskohaaAnim.SetBool("Move_Up", true);
            LioskohaaAnim.SetBool("Move_Down", false);
        }

        if (shotTime > Random.RandomRange(2, 5) && death == false)
        {
            fire();
        }

        updateHealth();
        if (Boss_Health.LioskohaaHealth <= 0 && death == false)
        {
            KillSelf();
        }

        else
        {
            Invoke("ResetMaterial", 0.1f);
        }
    }

    private void updateHealth()
    {
        float ratio = Boss_Health.LioskohaaHealth / Boss_Health.LioskohaaMaxHealth;
        LioskohaaHealthBar.rectTransform.localScale = new Vector3(ratio, 1, 1);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Missile"))
        {
            Destroy(collision.gameObject);
            Boss_Health.LioskohaaHealth = Boss_Health.LioskohaaHealth - 10;
            sr.material = MatWhite;
            updateHealth();
        }

        if (collision.CompareTag("Laser"))
        {
            Destroy(collision.gameObject);
            Boss_Health.LioskohaaHealth = Boss_Health.LioskohaaHealth - 5;
            sr.material = MatWhite;
            updateHealth();
        }
    }

    public void RightAnswer()
    {
        Boss_Health.LioskohaaHealth = Boss_Health.LioskohaaHealth = 0;
    }
    void ResetMaterial()
    {
        sr.material = MatDefault;
    }

    public void fire()
    {
        Instantiate(missilePrefab, blaster.position, blaster.rotation);
        laserSource.PlayOneShot(laser);
        shotTime = 0f;
    }

    public void KillSelf()
    {
        PlayerScore.playerpoints = PlayerScore.playerpoints + 50;
        death = true;
        winScreen.SetActive(true);
        LioskohaaAnim.SetBool("Die", true);
        LioskohaaFightUi.SetActive(false);
    }
}
