using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Heohumm : MonoBehaviour
{
    public GameObject HeohummFightUi;
    public Image HeohummHealthBar;
    public Animator HeohummAnim;
    public Material MatWhite;
    private Material MatDefault;
    SpriteRenderer sr;
    private bool death = false;
    public bool trigger_once;
    private bool isTriggered;
    public Transform blaster;
    public GameObject missilePrefab;
    public GameObject winScreen;
    public float totalTime = 0f;
    public float shotTime = 0f;
    public float nextFire;
    public float randomFire = 1f;
    public float fireRate = 3f;
    public bool stopFiring = false;
    public float reloadTime = 0;
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
        reloadTime = Time.deltaTime;

        if (stopFiring == true)
        {
            if (reloadTime == 2.0f)
            {
                stopFiring = false;
                reloadTime = 0f;
            }
        }

        if (totalTime > 2.5 && totalTime < 3)
        {

        }

        if ((totalTime > 3) && (GetComponent<Transform>().position.y > 3) && death == false)
        {
            fire();
            HeohummAnim.SetBool("Move_Down", true);
            HeohummAnim.SetBool("Move_Up", false);
        }

        if ((totalTime > 3) && (GetComponent<Transform>().position.y < -3) && death == false)
        {
            HeohummAnim.SetBool("Move_Up", true);
            HeohummAnim.SetBool("Move_Down", false);
        }

        if (death == false && shotTime == 2)
        {
            fire();
        }

        updateHealth();
        if (Boss_Health.HeohummHealth <= 0 && death == false)
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
        float ratio = Boss_Health.HeohummHealth / Boss_Health.HeohummMaxHealth;
        HeohummHealthBar.rectTransform.localScale = new Vector3(ratio, 1, 1);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Missile"))
        {
            Destroy(collision.gameObject);
            Boss_Health.HeohummHealth = Boss_Health.HeohummHealth - 10;
            sr.material = MatWhite;
            updateHealth();
        }
    }

    public void RightAnswer()
    {
        Boss_Health.HeohummHealth = Boss_Health.HeohummHealth - 100;
    }
    void ResetMaterial()
    {
        sr.material = MatDefault;
    }

    public void fire()
    {
            Instantiate(missilePrefab, blaster.position, blaster.rotation);
            shotTime = 0f;
    }

    public void Reload()
    {

    }

    private void KillSelf()
    {
        PlayerScore.playerpoints = PlayerScore.playerpoints + 50;
        death = true;
        winScreen.SetActive(true);
        HeohummAnim.SetBool("Die", true);
        HeohummFightUi.SetActive(false);
    }
}
