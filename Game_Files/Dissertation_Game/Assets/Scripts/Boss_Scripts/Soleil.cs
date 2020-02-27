using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Soleil : MonoBehaviour
{
    public GameObject SoleilFightUi;
    public Image SoleilHealthBar;
    public Animator SoleilAnim;
    public Material MatWhite;
    private Material MatDefault;
    SpriteRenderer sr;
    private bool death = false;
    public bool trigger_once;
    private bool isTriggered;
    public AudioClip laser;
    public AudioSource laserSource;
    public Transform blaster;
    public GameObject missilePrefab;
    public GameObject winScreen;
    public float totalTime = 0f;
    public float shotTime = 0f;
    public float nextFire;
    public float randomFire = 1f;
    public float fireRate = 3f;
    public static bool rightAnswer;
    public float rightAnswerDisable;
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
            SoleilAnim.SetBool("Move_Down", true);
            SoleilAnim.SetBool("Move_Up", false);
        }

        if ((totalTime > 3) && (GetComponent<Transform>().position.y < -3) && death == false)
        {
            SoleilAnim.SetBool("Move_Up", true);
            SoleilAnim.SetBool("Move_Down", false);
        }

        if (shotTime > Random.RandomRange(2,4) && death == false)
        {
            fire();
        }

        if (rightAnswer == true)
        {
            rightAnswerDisable += Time.deltaTime;
            if (rightAnswerDisable >= 10)
            {
                rightAnswer = false;
            }
        }

        updateHealth();
        if (Boss_Health.SoleilHealth <= 0 && death == false)
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
        float ratio = Boss_Health.SoleilHealth / Boss_Health.SoleilMaxHealth;
        SoleilHealthBar.rectTransform.localScale = new Vector3(ratio, 1, 1);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Missile"))
        {
            Destroy(collision.gameObject);
            Boss_Health.SoleilHealth = Boss_Health.SoleilHealth - 10;
            sr.material = MatWhite;
            updateHealth();
        }

        if (collision.CompareTag("Laser"))
        {
            Destroy(collision.gameObject);
            Boss_Health.SoleilHealth = Boss_Health.SoleilHealth - 5;
            sr.material = MatWhite;
            updateHealth();
        }
    }

    public void RightAnswer()
    {
        rightAnswer = true;
    }
    void ResetMaterial()
    {
        sr.material = MatDefault;
    }

    public void fire()
    {
        if (rightAnswer == false)
        {
            Instantiate(missilePrefab, blaster.position, blaster.rotation);
            laserSource.PlayOneShot(laser);
            shotTime = 0f;
        }
    }

    private void KillSelf()
    {
        PlayerScore.playerpoints = PlayerScore.playerpoints + 50;
        death = true;
        winScreen.SetActive(true);
        SoleilAnim.SetBool("Die", true);
        SoleilFightUi.SetActive(false);
    }
}
