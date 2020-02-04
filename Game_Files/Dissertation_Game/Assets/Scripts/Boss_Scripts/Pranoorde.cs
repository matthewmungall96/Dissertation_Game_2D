using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Pranoorde : MonoBehaviour
{
    public GameObject PranoordeFightUi;
    public Image PranoordeHealthBar;
    public Animator PranoordeAnim;
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
            PranoordeAnim.SetBool("Move_Down", true);
            PranoordeAnim.SetBool("Move_Up", false);
        }

        if ((totalTime > 3) && (GetComponent<Transform>().position.y < -3) && death == false)
        {
            PranoordeAnim.SetBool("Move_Up", true);
            PranoordeAnim.SetBool("Move_Down", false);
        }

        if (shotTime > Random.RandomRange(3, 6) && death == false)
        {
            fire();
        }

        updateHealth();
        if (Boss_Health.PranoordeHealth <= 0 && death == false)
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
        float ratio = Boss_Health.PranoordeHealth / Boss_Health.PranoordeMaxHealth;
        PranoordeHealthBar.rectTransform.localScale = new Vector3(ratio, 1, 1);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Missile"))
        {
            Destroy(collision.gameObject);
            Boss_Health.PranoordeHealth = Boss_Health.PranoordeHealth - 10;
            sr.material = MatWhite;
            updateHealth();
        }
    }

    public void RightAnswer()
    {
        Boss_Health.PranoordeHealth = Boss_Health.PranoordeHealth / 100 * 50;
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

    private void KillSelf()
    {
        death = true;
        winScreen.SetActive(true);
        PranoordeAnim.SetBool("Die", true);
        PranoordeFightUi.SetActive(false);
    }
}
