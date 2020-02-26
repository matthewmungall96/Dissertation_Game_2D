using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Chargers : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    private Transform Target;
    private int health =  15;
    public Material MatWhite;
    private Material MatDefault;
    SpriteRenderer sr;
    public Animator death;

    private void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        sr = GetComponent<SpriteRenderer>();
        spawn_crashers.isAlive = true;
        MatDefault = sr.material;
    }

    private void Update()
    {
        if (health > 0)
        {
            Tracked();
        }
    }

    private void Tracked()
    {
        {
            if (Vector2.Distance(transform.position, Target.position) > stoppingDistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, Target.position, speed * Time.deltaTime);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Missile"))
        {
            Destroy(collision.gameObject);
            health = health - 3;
            sr.material = MatWhite;
            if (health <= 0)
            {
                PlayerScore.playerpoints = PlayerScore.playerpoints + 5;
                Debug.Log("Shot Down");
                OnDeath();
            }

            else
            {
                Invoke("ResetMaterial", 0.1f);
            }
        }
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Suicide");
            health = 0;
            PlayerHealth.playerHealthNo = PlayerHealth.playerHealthNo - 30;
            OnDeath();
        }
    }

    void ResetMaterial()
    {
        sr.material = MatDefault;
    }

    public void OnDeath()
    {
        Invoke("ResetMaterial", 0.1f);
        death.SetBool("Dead", true);
        StartCoroutine(DeathWait());
    }

    IEnumerator DeathWait()
    {
        spawn_crashers.isAlive = false;
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}